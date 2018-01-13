using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CountriesAssignment
{

    public partial class MainForm : Form
    {
        CountryTree mainTree = new CountryTree();
        CountryTree resultsTree = new CountryTree();
        Country selectedCountry = new Country();
        string inputErrors = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            refreshMainForm();        
        }

        private void loadCountriesMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadCountries = new OpenFileDialog();
            loadCountries.Filter = "CSV Files|*.csv";
            loadCountries.Title = "Select a CSV File";

            if (loadCountries.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {              
                try
                {
                    string[] headers = new string[6];
                    const int MAX_LINES_FILE = 50000;
                    string[] AllLines = new string[MAX_LINES_FILE];
                    AllLines = File.ReadAllLines(loadCountries.FileName);
                    foreach (string line in AllLines)
                    {
                        if (line.StartsWith("Country"))
                        {
                            headers = line.Split(',');
                        }
                        else
                        {
                            string[] columns = line.Split(',');
                            LinkedList<String> tempList = new LinkedList<string>();
                            string[] partners = columns[5].Split(';', '[', ']');
                            foreach (string tradePartner in partners)
                            {
                                if (tradePartner != "")
                                {
                                    tempList.AddLast(tradePartner.Replace('_', ' '));
                                }
                            }

                            Country temp = new Country
                            {
                                Name = columns[0].Replace('_', ' '),
                                GdpGrowth = Convert.ToDouble(columns[1]),
                                Inflation = Convert.ToDouble(columns[2]),
                                TradeBalance = Convert.ToDouble(columns[3]),
                                HdiRanking = Convert.ToUInt32(columns[4]),
                                MainTradePartners = tempList
                            };
                            mainTree.InsertItem(temp);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please make sure that selected file is not already in use.\n\nIf file is not in use, please check for errors.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
            refreshMainForm();
        }

        private void addNewCountryMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add entered details as new Country?", "Add New Country", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (countryList.Items.Count != 0 && nameTextBox.Text.Equals(selectedCountry.Name, StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Country already exists.\n\nSuggestion: Try Selected Country -> Update Details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Country temp = new Country();

                validateInput(ref temp);

                if (!inputErrors.Equals(""))
                {
                    MessageBox.Show(inputErrors, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputErrors = "";
                }
                else
                {
                    setTradePartners(ref temp);
                    mainTree.InsertItem(temp);
                    refreshMainForm();
                }
            }
        }

        private void bigTradePotentiaMenuItem_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            clearSearchResults();
            Country biggestTradePotential = mainTree.GetBiggestTradePotential();
            resultsTree.InsertItem(biggestTradePotential);
            searchBoxLabel.Text = "Displaying Country with Biggest Trade Potential";
            countryList.DataSource = resultsTree.GetCountries();
            countryList.DisplayMember = "name";
            backButton.Enabled = true;
        }

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCountries = new SaveFileDialog();
            saveCountries.Filter = "Save Countries to CSV file|*.csv";
            if (saveCountries.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string headers = "Country,GDP growth,Inflation,Trade Balance,HDI Ranking,Main Trade Partners";
                string format = "{0},{1},{2},{3},{4},{5}";
                StreamWriter file;
                try
                {
                    file = new StreamWriter(saveCountries.FileName);
                    file.WriteLine(headers);
                    foreach (Country country in mainTree.GetCountries())
                    {
                        string partners = "[";
                        foreach (string partner in country.MainTradePartners)
                        {
                            partners = partners + partner.Replace(' ', '_') + ";";
                        }
                        partners = partners.Remove(partners.Length - 1);
                        partners = partners + "]";
                        file.WriteLine(String.Format(format, country.Name.Replace(' ', '_'), country.GdpGrowth, country.Inflation, country.TradeBalance, country.HdiRanking, partners));
                    }
                    if (file != null)
                    {
                        file.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Export was unsuccessful", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "End Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update details for " + selectedCountry.Name + "?", "Update Country", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nameTextBox.Text.Equals(selectedCountry.Name))
                {
                    updateCountry();
                }

                else if (!nameTextBox.Text.Equals(selectedCountry.Name))
                {
                    if (MessageBox.Show(selectedCountry.Name + " will be renamed to " + nameTextBox.Text, "Caution!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        updateCountry();
                    }
                }
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove " + selectedCountry.Name + " from the Main Tree?", "Delete Selected Country", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                mainTree.RemoveItem(selectedCountry);
                refreshMainForm();
            }           
        }

        private void findPartnersMenuItem_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            clearSearchResults();
            resultsTree = mainTree.FindTradePartners(selectedCountry);
            searchBoxLabel.Text = "Displaying all Trade Partners for " + selectedCountry.Name + ": " + resultsTree.Count();
            countryList.DataSource = resultsTree.GetCountries();
            countryList.DisplayMember = "name";
            backButton.Enabled = true;            
        }

        private void countryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tradePartnerList.Items.Clear();
            selectedCountry = (Country)countryList.SelectedItem;
            selectedCountryMenuItem.Enabled = true;
            nameTextBox.Text = selectedCountry.Name;
            gdpGrowthTextBox.Text = selectedCountry.GdpGrowth.ToString();
            inflationTextBox.Text = selectedCountry.Inflation.ToString();
            tradeBalanceTextBox.Text = selectedCountry.TradeBalance.ToString();
            hdiRankingTextBox.Text = selectedCountry.HdiRanking.ToString();
            newPartnerTextBox.Clear();
            foreach (string partner in selectedCountry.MainTradePartners)
            {
                tradePartnerList.Items.Add(partner);
            }
            tradePartnerList.Sorted = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Enabled = false;
            searchTextBox.Clear();
            searchBoxLabel.Text = "Search Country:";
            refreshMainForm();
        }

        private void addNewPartnerButton_Click(object sender, EventArgs e)
        {
            LinkedList<String> tempList = new LinkedList<string>();
            int size = tradePartnerList.Items.Count;
            string[] partners = new string[size];
            for (int i = 0; i < size; i++)
            {
                partners[i] = tradePartnerList.Items[i].ToString();
            }

            foreach (string tradePartner in partners)
            {
                if (tradePartner.Equals(newPartnerTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    inputErrors = "Trade partner already exists.";
                    MessageBox.Show(inputErrors, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputErrors = "";
                    return;
                }
            }
            if (validCountryName(newPartnerTextBox.Text))
            {
                tradePartnerList.Items.Add(newPartnerTextBox.Text);
                newPartnerTextBox.Clear();
                tradePartnerList.Sorted = true;
            }
            else
            {
                inputErrors = "Country name must contain letters or spaces only.";
                MessageBox.Show(inputErrors, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputErrors = "";
            }
        }

        private void deletePartnerButton_Click(object sender, EventArgs e)
        {
            tradePartnerList.Items.Remove(tradePartnerList.SelectedItem);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAllInput();
            selectedCountryMenuItem.Enabled = false;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                backButton.Enabled = false;
                refreshMainForm();
                clearSearchResults();
                searchBoxLabel.Text = "Search Country:";
            }
            else
            {
                backButton.Enabled = true;
                clearAllInput();
                foreach (Country country in mainTree.GetCountries())
                {
                    if (country.Name.ToLower().StartsWith(searchTerm.ToLower().Trim()))
                    {
                        resultsTree.InsertItem(country);
                    }
                }
                foreach (Country result in resultsTree.GetCountries())
                {
                    if (!result.Name.ToLower().StartsWith(searchTerm.ToLower().Trim()))
                    {
                        resultsTree.RemoveItem(result);
                    }
                }
                countryList.DataSource = resultsTree.GetCountries();
                countryList.DisplayMember = "name";
                searchBoxLabel.Text = "Search Results: " + resultsTree.Count();
            }

        }

        private void refreshMainForm()
        {
            countryList.DataSource = mainTree.GetCountries();
            countryList.DisplayMember = "name";
            uniqueCountriesLabel.Text = "Unique Countries: " + mainTree.Count();
            treeHeightLabel.Text = "Tree Height: " + mainTree.Height();
            searchTextBox.Clear();
            inputErrors = "";
            if (countryList.Items.Count == 0)
            {
                bigTradePotentiaMenuItem.Enabled = false;
                exportMenuItem.Enabled = false;
                selectedCountryMenuItem.Enabled = false;
            }
            else
            {
                bigTradePotentiaMenuItem.Enabled = true;
                exportMenuItem.Enabled = true;
                selectedCountryMenuItem.Enabled = true;
            }
            if (countryList.Items.Count == 0)
            {
                clearAllInput();
            }
        }
        
        private void updateCountry()
        {
            Country temp = new Country();
            validateInput(ref temp);
            setTradePartners(ref temp);

            if (!inputErrors.Equals(""))
            {
                MessageBox.Show(inputErrors, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputErrors = "";
            }
            else
            {
                mainTree.RemoveItem(selectedCountry);               
                mainTree.InsertItem(temp);
                refreshMainForm();
            }
        }

        private void clearAllInput()
        {
            tradePartnerList.Items.Clear();
            nameTextBox.Clear();
            gdpGrowthTextBox.Clear();
            inflationTextBox.Clear();
            tradeBalanceTextBox.Clear();
            hdiRankingTextBox.Clear();
            newPartnerTextBox.Clear();
            selectedCountry = null;
        }

        private void clearSearchResults()
        {
            foreach (Country result in resultsTree.GetCountries())
            {
                resultsTree.RemoveItem(result);
            }
        }
        
        private Boolean validCountryName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            char[] letters = input.ToCharArray();
            foreach (char l in letters)
            {
                if (l == ' ')
                {
                    return true;
                }
                if (!Char.IsLetter(l))
                {
                    return false;
                }
            }
            return true;
        }

        private Boolean validDouble(string input)
        {
            try
            {
                Convert.ToDouble(input);
            }
            catch
            {
                return false;
            }
            return true;
        }
        
        private Boolean validInteger(string input)
        {
            if (Convert.ToUInt32(input) == 0)
            {
                return false;
            }
            try
            {
                Convert.ToUInt32(input);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void validateInput(ref Country temp)
        {
            if (validCountryName(nameTextBox.Text) && !nameTextBox.Text.Equals(""))
            {
                temp.Name = nameTextBox.Text;
            }
            else
            {
                inputErrors = "Country name must contain letters or spaces only.";
            }

            if (validDouble(gdpGrowthTextBox.Text) && !gdpGrowthTextBox.Text.Equals(""))
            {
                temp.GdpGrowth = Convert.ToDouble(gdpGrowthTextBox.Text);
            }
            else
            {
                if (!inputErrors.Equals(""))
                {
                    inputErrors = inputErrors + "\nGDP Growth must be a valid number.";
                }
                else
                {
                    inputErrors = "GDP Growth must be a valid number.";
                }
            }

            if (validDouble(inflationTextBox.Text) && !inflationTextBox.Text.Equals(""))
            {
                temp.Inflation = Convert.ToDouble(inflationTextBox.Text);
            }
            else
            {
                if (!inputErrors.Equals(""))
                {
                    inputErrors = inputErrors + "\nInflation must be a valid number.";
                }
                else
                {
                    inputErrors = "Inflation must be a valid number.";
                }
            }

            if (validDouble(tradeBalanceTextBox.Text) && !tradeBalanceTextBox.Text.Equals(""))
            {
                temp.TradeBalance = Convert.ToDouble(tradeBalanceTextBox.Text);
            }
            else
            {
                if (!inputErrors.Equals(""))
                {
                    inputErrors = inputErrors + "\nTrade Balance must be a valid number.";
                }
                else
                {
                    inputErrors = "Trade Balance must be a valid number.";
                }
            }

            if (validInteger(hdiRankingTextBox.Text) && !hdiRankingTextBox.Text.Equals(""))
            {
                temp.HdiRanking = Convert.ToUInt32(hdiRankingTextBox.Text);
            }
            else
            {
                if (!inputErrors.Equals(""))
                {
                    inputErrors = inputErrors + "\nHDI Ranking must be a whole number greater than 0.";
                }
                else
                {
                    inputErrors = "HDI Ranking must be a whole number greater than 0";
                }
            }

            if (tradePartnerList.Items.Count == 0)
            {
                if (!inputErrors.Equals(""))
                {
                    inputErrors = inputErrors + "\nTrade partner(s) required.";
                }
                else
                {
                    inputErrors = "Trade partner(s) required.";
                }
            }
        }
        
        private void setTradePartners(ref Country temp)
        {
            LinkedList<String> tempList = new LinkedList<string>();
            int size = tradePartnerList.Items.Count;
            string[] partners = new string[size];
            for (int i = 0; i < size; i++)
            {
                partners[i] = tradePartnerList.Items[i].ToString();
            }
           
            foreach (string tradePartner in partners)
            {
                tempList.AddLast(tradePartner);
            }
            temp.MainTradePartners = tempList;
        }       
    }
}    