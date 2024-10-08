﻿namespace IMDBFilmLibrary
{
    partial class EpisodeDataForm
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
            storeEpisodesDataBtn = new Button();
            retrieveEpisodesDataBtn = new Button();
            searchBox3 = new TextBox();
            searchRatingsBtn = new Button();
            episodeListBox = new ListBox();
            SuspendLayout();
            // 
            // storeEpisodesDataBtn
            // 
            storeEpisodesDataBtn.Location = new Point(820, 25);
            storeEpisodesDataBtn.Name = "storeEpisodesDataBtn";
            storeEpisodesDataBtn.Size = new Size(262, 46);
            storeEpisodesDataBtn.TabIndex = 5;
            storeEpisodesDataBtn.Text = "Store Data";
            storeEpisodesDataBtn.UseVisualStyleBackColor = true;
            // 
            // retrieveEpisodesDataBtn
            // 
            retrieveEpisodesDataBtn.Location = new Point(820, 77);
            retrieveEpisodesDataBtn.Name = "retrieveEpisodesDataBtn";
            retrieveEpisodesDataBtn.Size = new Size(256, 46);
            retrieveEpisodesDataBtn.TabIndex = 6;
            retrieveEpisodesDataBtn.Text = "Retrieve Data";
            retrieveEpisodesDataBtn.UseVisualStyleBackColor = true;
            retrieveEpisodesDataBtn.Click += retrieveEpisodesDataBtn_Click;
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(727, 129);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(355, 39);
            searchBox3.TabIndex = 7;
            searchBox3.Text = "Search for data here!";
            // 
            // searchRatingsBtn
            // 
            searchRatingsBtn.Location = new Point(727, 174);
            searchRatingsBtn.Name = "searchRatingsBtn";
            searchRatingsBtn.Size = new Size(355, 46);
            searchRatingsBtn.TabIndex = 8;
            searchRatingsBtn.Text = "Search";
            searchRatingsBtn.UseVisualStyleBackColor = true;
            // 
            // episodeListBox
            // 
            episodeListBox.FormattingEnabled = true;
            episodeListBox.Location = new Point(50, 32);
            episodeListBox.Name = "episodeListBox";
            episodeListBox.Size = new Size(624, 644);
            episodeListBox.TabIndex = 9;
            // 
            // EpisodeDataForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 732);
            Controls.Add(episodeListBox);
            Controls.Add(searchRatingsBtn);
            Controls.Add(searchBox3);
            Controls.Add(retrieveEpisodesDataBtn);
            Controls.Add(storeEpisodesDataBtn);
            Name = "EpisodeDataForm";
            Text = "EpisodeDataForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button storeEpisodesDataBtn;
        private Button retrieveEpisodesDataBtn;
        private TextBox searchBox3;
        private Button searchRatingsBtn;
        private ListBox episodeListBox;
    }
}