﻿namespace IMDBFilmLibrary
{
    partial class RatingsDataForm
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
            ratingsDataList = new TextBox();
            storeRatingsDataBtn = new Button();
            retrieveRatingsDataBtn = new Button();
            searchBox2 = new TextBox();
            searchRatingsBtn = new Button();
            SuspendLayout();
            // 
            // ratingsDataList
            // 
            ratingsDataList.Location = new Point(12, 25);
            ratingsDataList.Name = "ratingsDataList";
            ratingsDataList.Size = new Size(907, 39);
            ratingsDataList.TabIndex = 3;
            ratingsDataList.Text = "Retrieved ratings data goes here...";
            // 
            // storeRatingsDataBtn
            // 
            storeRatingsDataBtn.Location = new Point(957, 25);
            storeRatingsDataBtn.Name = "storeRatingsDataBtn";
            storeRatingsDataBtn.Size = new Size(262, 46);
            storeRatingsDataBtn.TabIndex = 4;
            storeRatingsDataBtn.Text = "Store Data";
            storeRatingsDataBtn.UseVisualStyleBackColor = true;
            // 
            // retrieveRatingsDataBtn
            // 
            retrieveRatingsDataBtn.Location = new Point(957, 77);
            retrieveRatingsDataBtn.Name = "retrieveRatingsDataBtn";
            retrieveRatingsDataBtn.Size = new Size(256, 46);
            retrieveRatingsDataBtn.TabIndex = 5;
            retrieveRatingsDataBtn.Text = "Retrieve Data";
            retrieveRatingsDataBtn.UseVisualStyleBackColor = true;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(858, 129);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(355, 39);
            searchBox2.TabIndex = 6;
            searchBox2.Text = "Search for data here!";
            // 
            // searchRatingsBtn
            // 
            searchRatingsBtn.Location = new Point(847, 174);
            searchRatingsBtn.Name = "searchRatingsBtn";
            searchRatingsBtn.Size = new Size(355, 46);
            searchRatingsBtn.TabIndex = 7;
            searchRatingsBtn.Text = "Search";
            searchRatingsBtn.UseVisualStyleBackColor = true;
            // 
            // RatingsDataForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 752);
            Controls.Add(searchRatingsBtn);
            Controls.Add(searchBox2);
            Controls.Add(retrieveRatingsDataBtn);
            Controls.Add(storeRatingsDataBtn);
            Controls.Add(ratingsDataList);
            Name = "RatingsDataForm";
            Text = "RatingsDataForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ratingsDataList;
        private Button storeRatingsDataBtn;
        private Button retrieveRatingsDataBtn;
        private TextBox searchBox2;
        private Button searchRatingsBtn;
    }
}