namespace CountriesAssignment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.countryGroupBox = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.countryList = new System.Windows.Forms.ListBox();
            this.countryInformationBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.hdiRankingTextBox = new System.Windows.Forms.TextBox();
            this.tradeBalanceTextBox = new System.Windows.Forms.TextBox();
            this.inflationTextBox = new System.Windows.Forms.TextBox();
            this.gdpGrowthTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tradePartnerBox = new System.Windows.Forms.GroupBox();
            this.deletePartnerButton = new System.Windows.Forms.Button();
            this.newPartnerTextBox = new System.Windows.Forms.TextBox();
            this.addNewPartnerButton = new System.Windows.Forms.Button();
            this.tradePartnerList = new System.Windows.Forms.ListBox();
            this.hdiRankingLabel = new System.Windows.Forms.Label();
            this.tradeBalanceLabel = new System.Windows.Forms.Label();
            this.inflationLabel = new System.Windows.Forms.Label();
            this.gdpGrowthLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.treeInformationLabel = new System.Windows.Forms.GroupBox();
            this.treeHeightLabel = new System.Windows.Forms.Label();
            this.uniqueCountriesLabel = new System.Windows.Forms.Label();
            this.searchBoxLabel = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCountriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCountryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigTradePotentiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedCountryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPartnersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryGroupBox.SuspendLayout();
            this.countryInformationBox.SuspendLayout();
            this.tradePartnerBox.SuspendLayout();
            this.treeInformationLabel.SuspendLayout();
            this.searchBoxLabel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryGroupBox
            // 
            this.countryGroupBox.Controls.Add(this.backButton);
            this.countryGroupBox.Controls.Add(this.countryList);
            this.countryGroupBox.Location = new System.Drawing.Point(12, 27);
            this.countryGroupBox.Name = "countryGroupBox";
            this.countryGroupBox.Size = new System.Drawing.Size(188, 324);
            this.countryGroupBox.TabIndex = 9;
            this.countryGroupBox.TabStop = false;
            this.countryGroupBox.Text = "Country List:";
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(9, 290);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(168, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // countryList
            // 
            this.countryList.FormattingEnabled = true;
            this.countryList.Location = new System.Drawing.Point(6, 19);
            this.countryList.Name = "countryList";
            this.countryList.Size = new System.Drawing.Size(171, 264);
            this.countryList.TabIndex = 5;
            this.countryList.SelectedIndexChanged += new System.EventHandler(this.countryList_SelectedIndexChanged);
            // 
            // countryInformationBox
            // 
            this.countryInformationBox.Controls.Add(this.clearButton);
            this.countryInformationBox.Controls.Add(this.hdiRankingTextBox);
            this.countryInformationBox.Controls.Add(this.tradeBalanceTextBox);
            this.countryInformationBox.Controls.Add(this.inflationTextBox);
            this.countryInformationBox.Controls.Add(this.gdpGrowthTextBox);
            this.countryInformationBox.Controls.Add(this.nameTextBox);
            this.countryInformationBox.Controls.Add(this.tradePartnerBox);
            this.countryInformationBox.Controls.Add(this.hdiRankingLabel);
            this.countryInformationBox.Controls.Add(this.tradeBalanceLabel);
            this.countryInformationBox.Controls.Add(this.inflationLabel);
            this.countryInformationBox.Controls.Add(this.gdpGrowthLabel);
            this.countryInformationBox.Controls.Add(this.nameLabel);
            this.countryInformationBox.Location = new System.Drawing.Point(212, 27);
            this.countryInformationBox.Name = "countryInformationBox";
            this.countryInformationBox.Size = new System.Drawing.Size(200, 324);
            this.countryInformationBox.TabIndex = 10;
            this.countryInformationBox.TabStop = false;
            this.countryInformationBox.Text = "Country Information:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(7, 290);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(188, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // hdiRankingTextBox
            // 
            this.hdiRankingTextBox.Location = new System.Drawing.Point(94, 123);
            this.hdiRankingTextBox.Name = "hdiRankingTextBox";
            this.hdiRankingTextBox.Size = new System.Drawing.Size(100, 20);
            this.hdiRankingTextBox.TabIndex = 10;
            // 
            // tradeBalanceTextBox
            // 
            this.tradeBalanceTextBox.Location = new System.Drawing.Point(94, 96);
            this.tradeBalanceTextBox.Name = "tradeBalanceTextBox";
            this.tradeBalanceTextBox.Size = new System.Drawing.Size(101, 20);
            this.tradeBalanceTextBox.TabIndex = 9;
            // 
            // inflationTextBox
            // 
            this.inflationTextBox.Location = new System.Drawing.Point(94, 69);
            this.inflationTextBox.Name = "inflationTextBox";
            this.inflationTextBox.Size = new System.Drawing.Size(100, 20);
            this.inflationTextBox.TabIndex = 8;
            // 
            // gdpGrowthTextBox
            // 
            this.gdpGrowthTextBox.Location = new System.Drawing.Point(94, 43);
            this.gdpGrowthTextBox.Name = "gdpGrowthTextBox";
            this.gdpGrowthTextBox.Size = new System.Drawing.Size(100, 20);
            this.gdpGrowthTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // tradePartnerBox
            // 
            this.tradePartnerBox.Controls.Add(this.deletePartnerButton);
            this.tradePartnerBox.Controls.Add(this.newPartnerTextBox);
            this.tradePartnerBox.Controls.Add(this.addNewPartnerButton);
            this.tradePartnerBox.Controls.Add(this.tradePartnerList);
            this.tradePartnerBox.Location = new System.Drawing.Point(10, 149);
            this.tradePartnerBox.Name = "tradePartnerBox";
            this.tradePartnerBox.Size = new System.Drawing.Size(184, 139);
            this.tradePartnerBox.TabIndex = 5;
            this.tradePartnerBox.TabStop = false;
            this.tradePartnerBox.Text = "Main Trade Partners:";
            // 
            // deletePartnerButton
            // 
            this.deletePartnerButton.Location = new System.Drawing.Point(3, 111);
            this.deletePartnerButton.Name = "deletePartnerButton";
            this.deletePartnerButton.Size = new System.Drawing.Size(174, 23);
            this.deletePartnerButton.TabIndex = 3;
            this.deletePartnerButton.Text = "Delete Selected Trade Partner";
            this.deletePartnerButton.UseVisualStyleBackColor = true;
            this.deletePartnerButton.Click += new System.EventHandler(this.deletePartnerButton_Click);
            // 
            // newPartnerTextBox
            // 
            this.newPartnerTextBox.Location = new System.Drawing.Point(3, 85);
            this.newPartnerTextBox.Name = "newPartnerTextBox";
            this.newPartnerTextBox.Size = new System.Drawing.Size(96, 20);
            this.newPartnerTextBox.TabIndex = 2;
            // 
            // addNewPartnerButton
            // 
            this.addNewPartnerButton.Location = new System.Drawing.Point(105, 83);
            this.addNewPartnerButton.Name = "addNewPartnerButton";
            this.addNewPartnerButton.Size = new System.Drawing.Size(72, 23);
            this.addNewPartnerButton.TabIndex = 1;
            this.addNewPartnerButton.Text = "Add Partner";
            this.addNewPartnerButton.UseVisualStyleBackColor = true;
            this.addNewPartnerButton.Click += new System.EventHandler(this.addNewPartnerButton_Click);
            // 
            // tradePartnerList
            // 
            this.tradePartnerList.FormattingEnabled = true;
            this.tradePartnerList.Location = new System.Drawing.Point(3, 20);
            this.tradePartnerList.Name = "tradePartnerList";
            this.tradePartnerList.Size = new System.Drawing.Size(175, 56);
            this.tradePartnerList.TabIndex = 0;
            // 
            // hdiRankingLabel
            // 
            this.hdiRankingLabel.AutoSize = true;
            this.hdiRankingLabel.Location = new System.Drawing.Point(7, 124);
            this.hdiRankingLabel.Name = "hdiRankingLabel";
            this.hdiRankingLabel.Size = new System.Drawing.Size(72, 13);
            this.hdiRankingLabel.TabIndex = 4;
            this.hdiRankingLabel.Text = "HDI Ranking:";
            // 
            // tradeBalanceLabel
            // 
            this.tradeBalanceLabel.AutoSize = true;
            this.tradeBalanceLabel.Location = new System.Drawing.Point(7, 98);
            this.tradeBalanceLabel.Name = "tradeBalanceLabel";
            this.tradeBalanceLabel.Size = new System.Drawing.Size(80, 13);
            this.tradeBalanceLabel.TabIndex = 3;
            this.tradeBalanceLabel.Text = "Trade Balance:";
            // 
            // inflationLabel
            // 
            this.inflationLabel.AutoSize = true;
            this.inflationLabel.Location = new System.Drawing.Point(7, 72);
            this.inflationLabel.Name = "inflationLabel";
            this.inflationLabel.Size = new System.Drawing.Size(47, 13);
            this.inflationLabel.TabIndex = 2;
            this.inflationLabel.Text = "Inflation:";
            // 
            // gdpGrowthLabel
            // 
            this.gdpGrowthLabel.AutoSize = true;
            this.gdpGrowthLabel.Location = new System.Drawing.Point(7, 46);
            this.gdpGrowthLabel.Name = "gdpGrowthLabel";
            this.gdpGrowthLabel.Size = new System.Drawing.Size(70, 13);
            this.gdpGrowthLabel.TabIndex = 1;
            this.gdpGrowthLabel.Text = "GDP Growth:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // treeInformationLabel
            // 
            this.treeInformationLabel.Controls.Add(this.treeHeightLabel);
            this.treeInformationLabel.Controls.Add(this.uniqueCountriesLabel);
            this.treeInformationLabel.Location = new System.Drawing.Point(12, 402);
            this.treeInformationLabel.Name = "treeInformationLabel";
            this.treeInformationLabel.Size = new System.Drawing.Size(400, 36);
            this.treeInformationLabel.TabIndex = 11;
            this.treeInformationLabel.TabStop = false;
            this.treeInformationLabel.Text = "Tree Information:";
            // 
            // treeHeightLabel
            // 
            this.treeHeightLabel.AutoSize = true;
            this.treeHeightLabel.Location = new System.Drawing.Point(200, 16);
            this.treeHeightLabel.Name = "treeHeightLabel";
            this.treeHeightLabel.Size = new System.Drawing.Size(66, 13);
            this.treeHeightLabel.TabIndex = 1;
            this.treeHeightLabel.Text = "Tree Height:";
            // 
            // uniqueCountriesLabel
            // 
            this.uniqueCountriesLabel.AutoSize = true;
            this.uniqueCountriesLabel.Location = new System.Drawing.Point(6, 16);
            this.uniqueCountriesLabel.Name = "uniqueCountriesLabel";
            this.uniqueCountriesLabel.Size = new System.Drawing.Size(91, 13);
            this.uniqueCountriesLabel.TabIndex = 0;
            this.uniqueCountriesLabel.Text = "Unique Countries:";
            // 
            // searchBoxLabel
            // 
            this.searchBoxLabel.Controls.Add(this.searchTextBox);
            this.searchBoxLabel.Location = new System.Drawing.Point(12, 357);
            this.searchBoxLabel.Name = "searchBoxLabel";
            this.searchBoxLabel.Size = new System.Drawing.Size(400, 42);
            this.searchBoxLabel.TabIndex = 12;
            this.searchBoxLabel.TabStop = false;
            this.searchBoxLabel.Text = "Search Country:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(389, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.selectedCountryMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(417, 24);
            this.mainMenu.TabIndex = 13;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCountriesMenuItem,
            this.addNewCountryMenuItem,
            this.bigTradePotentiaMenuItem,
            this.exportMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // loadCountriesMenuItem
            // 
            this.loadCountriesMenuItem.Name = "loadCountriesMenuItem";
            this.loadCountriesMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadCountriesMenuItem.Size = new System.Drawing.Size(214, 22);
            this.loadCountriesMenuItem.Text = "Load Countries";
            this.loadCountriesMenuItem.Click += new System.EventHandler(this.loadCountriesMenuItem_Click);
            // 
            // addNewCountryMenuItem
            // 
            this.addNewCountryMenuItem.Name = "addNewCountryMenuItem";
            this.addNewCountryMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewCountryMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addNewCountryMenuItem.Text = "Add New Country";
            this.addNewCountryMenuItem.Click += new System.EventHandler(this.addNewCountryMenuItem_Click);
            // 
            // bigTradePotentiaMenuItem
            // 
            this.bigTradePotentiaMenuItem.Name = "bigTradePotentiaMenuItem";
            this.bigTradePotentiaMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bigTradePotentiaMenuItem.Size = new System.Drawing.Size(214, 22);
            this.bigTradePotentiaMenuItem.Text = "Big Trade Potential";
            this.bigTradePotentiaMenuItem.Click += new System.EventHandler(this.bigTradePotentiaMenuItem_Click);
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exportMenuItem.Text = "Export to CSV";
            this.exportMenuItem.Click += new System.EventHandler(this.exportMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // selectedCountryMenuItem
            // 
            this.selectedCountryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMenuItem,
            this.deleteMenuItem,
            this.findPartnersMenuItem});
            this.selectedCountryMenuItem.Name = "selectedCountryMenuItem";
            this.selectedCountryMenuItem.Size = new System.Drawing.Size(109, 20);
            this.selectedCountryMenuItem.Text = "Selected Country";
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateMenuItem.Size = new System.Drawing.Size(233, 22);
            this.updateMenuItem.Text = "Update Details";
            this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteMenuItem.Size = new System.Drawing.Size(233, 22);
            this.deleteMenuItem.Text = "Delete Country";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // findPartnersMenuItem
            // 
            this.findPartnersMenuItem.Name = "findPartnersMenuItem";
            this.findPartnersMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.findPartnersMenuItem.Size = new System.Drawing.Size(233, 22);
            this.findPartnersMenuItem.Text = "Find All Trade Partners";
            this.findPartnersMenuItem.Click += new System.EventHandler(this.findPartnersMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 442);
            this.Controls.Add(this.searchBoxLabel);
            this.Controls.Add(this.treeInformationLabel);
            this.Controls.Add(this.countryInformationBox);
            this.Controls.Add(this.countryGroupBox);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Trading Data";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.countryGroupBox.ResumeLayout(false);
            this.countryInformationBox.ResumeLayout(false);
            this.countryInformationBox.PerformLayout();
            this.tradePartnerBox.ResumeLayout(false);
            this.tradePartnerBox.PerformLayout();
            this.treeInformationLabel.ResumeLayout(false);
            this.treeInformationLabel.PerformLayout();
            this.searchBoxLabel.ResumeLayout(false);
            this.searchBoxLabel.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox countryGroupBox;
        private System.Windows.Forms.GroupBox countryInformationBox;
        private System.Windows.Forms.GroupBox tradePartnerBox;
        private System.Windows.Forms.ListBox tradePartnerList;
        private System.Windows.Forms.Label hdiRankingLabel;
        private System.Windows.Forms.Label tradeBalanceLabel;
        private System.Windows.Forms.Label inflationLabel;
        private System.Windows.Forms.Label gdpGrowthLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox treeInformationLabel;
        private System.Windows.Forms.Label uniqueCountriesLabel;
        private System.Windows.Forms.Label treeHeightLabel;
        private System.Windows.Forms.GroupBox searchBoxLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox countryList;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox inflationTextBox;
        private System.Windows.Forms.TextBox gdpGrowthTextBox;
        private System.Windows.Forms.TextBox hdiRankingTextBox;
        private System.Windows.Forms.TextBox tradeBalanceTextBox;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCountriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCountryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedCountryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPartnersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigTradePotentiaMenuItem;
        private System.Windows.Forms.Button deletePartnerButton;
        private System.Windows.Forms.TextBox newPartnerTextBox;
        private System.Windows.Forms.Button addNewPartnerButton;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
    }
}

