namespace IMDBFilmLibrary
{
    partial class CrewDataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            retrieveCrewDataBtn = new Button();
            storeCrewDataBtn = new Button();
            crewDataList = new TextBox();
            searchBox = new TextBox();
            searchCrewBtn = new Button();
            SuspendLayout();
            // 
            // retrieveCrewDataBtn
            // 
            retrieveCrewDataBtn.Location = new Point(1043, 117);
            retrieveCrewDataBtn.Name = "retrieveCrewDataBtn";
            retrieveCrewDataBtn.Size = new Size(256, 46);
            retrieveCrewDataBtn.TabIndex = 0;
            retrieveCrewDataBtn.Text = "Retrieve Data";
            retrieveCrewDataBtn.UseVisualStyleBackColor = true;
            retrieveCrewDataBtn.Click += retrieveCrewDataBtn_Click;
            // 
            // storeCrewDataBtn
            // 
            storeCrewDataBtn.Location = new Point(1043, 47);
            storeCrewDataBtn.Name = "storeCrewDataBtn";
            storeCrewDataBtn.Size = new Size(262, 46);
            storeCrewDataBtn.TabIndex = 1;
            storeCrewDataBtn.Text = "Store Data";
            storeCrewDataBtn.UseVisualStyleBackColor = true;
            // 
            // crewDataList
            // 
            crewDataList.Location = new Point(31, 49);
            crewDataList.Name = "crewDataList";
            crewDataList.Size = new Size(907, 39);
            crewDataList.TabIndex = 2;
            crewDataList.Text = "Retrieved crew data goes here...";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(950, 178);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(355, 39);
            searchBox.TabIndex = 3;
            searchBox.Text = "Search for data here!";
            // 
            // searchCrewBtn
            // 
            searchCrewBtn.Location = new Point(950, 232);
            searchCrewBtn.Name = "searchCrewBtn";
            searchCrewBtn.Size = new Size(355, 46);
            searchCrewBtn.TabIndex = 4;
            searchCrewBtn.Text = "Search";
            searchCrewBtn.UseVisualStyleBackColor = true;
            // 
            // CrewDataForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 963);
            Controls.Add(searchCrewBtn);
            Controls.Add(searchBox);
            Controls.Add(crewDataList);
            Controls.Add(storeCrewDataBtn);
            Controls.Add(retrieveCrewDataBtn);
            Name = "CrewDataForm";
            Text = "Crew Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button retrieveCrewDataBtn;
        private Button storeCrewDataBtn;
        private TextBox crewDataList;
        private TextBox searchBox;
        private Button searchCrewBtn;
    }
}
