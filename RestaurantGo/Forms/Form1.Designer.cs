namespace DBprojectToDoList
{
    partial class RestaurantLister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantLister));
            this.programLabel = new System.Windows.Forms.Label();
            this.countryPicker = new System.Windows.Forms.ComboBox();
            this.cityPicker = new System.Windows.Forms.ComboBox();
            this.cuisinePicker = new System.Windows.Forms.ComboBox();
            this.ratingPickerFrom = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cuisineLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingPickerTo = new System.Windows.Forms.ComboBox();
            this.ratingLabelFrom = new System.Windows.Forms.Label();
            this.ratingLabelTo = new System.Windows.Forms.Label();
            this.restaurantGrid = new System.Windows.Forms.DataGridView();
            this.filterRestaurantsButton = new System.Windows.Forms.Button();
            this.filterMyListButton = new System.Windows.Forms.Button();
            this.restaurantGridLabel = new System.Windows.Forms.Label();
            this.myListGrid = new System.Windows.Forms.DataGridView();
            this.myListLabel = new System.Windows.Forms.Label();
            this.addToMyListButton = new System.Windows.Forms.Button();
            this.markAsVisitedButton = new System.Windows.Forms.Button();
            this.rateButton = new System.Windows.Forms.Button();
            this.sortOriginalButton = new System.Windows.Forms.Button();
            this.sortMyRatingButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.footNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // programLabel
            // 
            this.programLabel.Font = new System.Drawing.Font("JetBrains Mono", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programLabel.ForeColor = System.Drawing.Color.White;
            this.programLabel.Location = new System.Drawing.Point(29, 9);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(1142, 78);
            this.programLabel.TabIndex = 0;
            this.programLabel.Text = "Restaurant Lister";
            this.programLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryPicker
            // 
            this.countryPicker.FormattingEnabled = true;
            this.countryPicker.Location = new System.Drawing.Point(29, 116);
            this.countryPicker.Name = "countryPicker";
            this.countryPicker.Size = new System.Drawing.Size(364, 23);
            this.countryPicker.TabIndex = 1;
            // 
            // cityPicker
            // 
            this.cityPicker.FormattingEnabled = true;
            this.cityPicker.Location = new System.Drawing.Point(29, 179);
            this.cityPicker.Name = "cityPicker";
            this.cityPicker.Size = new System.Drawing.Size(364, 23);
            this.cityPicker.TabIndex = 2;
            // 
            // cuisinePicker
            // 
            this.cuisinePicker.FormattingEnabled = true;
            this.cuisinePicker.Location = new System.Drawing.Point(29, 241);
            this.cuisinePicker.Name = "cuisinePicker";
            this.cuisinePicker.Size = new System.Drawing.Size(364, 23);
            this.cuisinePicker.TabIndex = 3;
            // 
            // ratingPickerFrom
            // 
            this.ratingPickerFrom.FormattingEnabled = true;
            this.ratingPickerFrom.Location = new System.Drawing.Point(123, 315);
            this.ratingPickerFrom.Name = "ratingPickerFrom";
            this.ratingPickerFrom.Size = new System.Drawing.Size(81, 23);
            this.ratingPickerFrom.TabIndex = 4;
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.ForeColor = System.Drawing.Color.White;
            this.countryLabel.Location = new System.Drawing.Point(29, 87);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(364, 23);
            this.countryLabel.TabIndex = 5;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(29, 150);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(364, 23);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City";
            // 
            // cuisineLabel
            // 
            this.cuisineLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cuisineLabel.ForeColor = System.Drawing.Color.White;
            this.cuisineLabel.Location = new System.Drawing.Point(29, 212);
            this.cuisineLabel.Name = "cuisineLabel";
            this.cuisineLabel.Size = new System.Drawing.Size(364, 23);
            this.cuisineLabel.TabIndex = 7;
            this.cuisineLabel.Text = "Cuisine";
            // 
            // ratingLabel
            // 
            this.ratingLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ratingLabel.ForeColor = System.Drawing.Color.White;
            this.ratingLabel.Location = new System.Drawing.Point(29, 277);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(364, 23);
            this.ratingLabel.TabIndex = 8;
            this.ratingLabel.Text = "Rating";
            // 
            // ratingPickerTo
            // 
            this.ratingPickerTo.FormattingEnabled = true;
            this.ratingPickerTo.Location = new System.Drawing.Point(269, 314);
            this.ratingPickerTo.Name = "ratingPickerTo";
            this.ratingPickerTo.Size = new System.Drawing.Size(81, 23);
            this.ratingPickerTo.TabIndex = 9;
            // 
            // ratingLabelFrom
            // 
            this.ratingLabelFrom.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ratingLabelFrom.ForeColor = System.Drawing.Color.White;
            this.ratingLabelFrom.Location = new System.Drawing.Point(64, 315);
            this.ratingLabelFrom.Name = "ratingLabelFrom";
            this.ratingLabelFrom.Size = new System.Drawing.Size(53, 23);
            this.ratingLabelFrom.TabIndex = 10;
            this.ratingLabelFrom.Text = "From:";
            this.ratingLabelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ratingLabelTo
            // 
            this.ratingLabelTo.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ratingLabelTo.ForeColor = System.Drawing.Color.White;
            this.ratingLabelTo.Location = new System.Drawing.Point(210, 314);
            this.ratingLabelTo.Name = "ratingLabelTo";
            this.ratingLabelTo.Size = new System.Drawing.Size(53, 23);
            this.ratingLabelTo.TabIndex = 11;
            this.ratingLabelTo.Text = "To:";
            this.ratingLabelTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ratingLabelTo.Click += new System.EventHandler(this.label2_Click);
            // 
            // restaurantGrid
            // 
            this.restaurantGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.restaurantGrid.BackgroundColor = System.Drawing.Color.White;
            this.restaurantGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantGrid.Location = new System.Drawing.Point(420, 116);
            this.restaurantGrid.Name = "restaurantGrid";
            this.restaurantGrid.RowTemplate.Height = 25;
            this.restaurantGrid.Size = new System.Drawing.Size(751, 481);
            this.restaurantGrid.TabIndex = 12;
            // 
            // filterRestaurantsButton
            // 
            this.filterRestaurantsButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterRestaurantsButton.Location = new System.Drawing.Point(29, 360);
            this.filterRestaurantsButton.Name = "filterRestaurantsButton";
            this.filterRestaurantsButton.Size = new System.Drawing.Size(364, 65);
            this.filterRestaurantsButton.TabIndex = 13;
            this.filterRestaurantsButton.Text = "List Restaurants with Selected Filters";
            this.filterRestaurantsButton.UseVisualStyleBackColor = true;
            // 
            // filterMyListButton
            // 
            this.filterMyListButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterMyListButton.Location = new System.Drawing.Point(29, 446);
            this.filterMyListButton.Name = "filterMyListButton";
            this.filterMyListButton.Size = new System.Drawing.Size(364, 65);
            this.filterMyListButton.TabIndex = 14;
            this.filterMyListButton.Text = "Apply Selected Filters to My List";
            this.filterMyListButton.UseVisualStyleBackColor = true;
            // 
            // restaurantGridLabel
            // 
            this.restaurantGridLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restaurantGridLabel.ForeColor = System.Drawing.Color.White;
            this.restaurantGridLabel.Location = new System.Drawing.Point(420, 87);
            this.restaurantGridLabel.Name = "restaurantGridLabel";
            this.restaurantGridLabel.Size = new System.Drawing.Size(751, 23);
            this.restaurantGridLabel.TabIndex = 16;
            this.restaurantGridLabel.Text = "Restaurants";
            // 
            // myListGrid
            // 
            this.myListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myListGrid.BackgroundColor = System.Drawing.Color.White;
            this.myListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myListGrid.Location = new System.Drawing.Point(29, 643);
            this.myListGrid.Name = "myListGrid";
            this.myListGrid.RowTemplate.Height = 25;
            this.myListGrid.Size = new System.Drawing.Size(1142, 308);
            this.myListGrid.TabIndex = 17;
            // 
            // myListLabel
            // 
            this.myListLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myListLabel.ForeColor = System.Drawing.Color.White;
            this.myListLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myListLabel.Location = new System.Drawing.Point(29, 614);
            this.myListLabel.Name = "myListLabel";
            this.myListLabel.Size = new System.Drawing.Size(1142, 23);
            this.myListLabel.TabIndex = 18;
            this.myListLabel.Text = "My List";
            this.myListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.myListLabel.Click += new System.EventHandler(this.myListLabel_Click);
            // 
            // addToMyListButton
            // 
            this.addToMyListButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addToMyListButton.Location = new System.Drawing.Point(29, 532);
            this.addToMyListButton.Name = "addToMyListButton";
            this.addToMyListButton.Size = new System.Drawing.Size(364, 65);
            this.addToMyListButton.TabIndex = 22;
            this.addToMyListButton.Text = "Add Selected Restaurants to My List";
            this.addToMyListButton.UseVisualStyleBackColor = true;
            // 
            // markAsVisitedButton
            // 
            this.markAsVisitedButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.markAsVisitedButton.Location = new System.Drawing.Point(489, 963);
            this.markAsVisitedButton.Name = "markAsVisitedButton";
            this.markAsVisitedButton.Size = new System.Drawing.Size(222, 65);
            this.markAsVisitedButton.TabIndex = 25;
            this.markAsVisitedButton.Text = "Mark as Visited";
            this.markAsVisitedButton.UseVisualStyleBackColor = true;
            // 
            // rateButton
            // 
            this.rateButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateButton.Location = new System.Drawing.Point(719, 963);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(222, 65);
            this.rateButton.TabIndex = 26;
            this.rateButton.Text = "Rate Restaurant";
            this.rateButton.UseVisualStyleBackColor = true;
            // 
            // sortOriginalButton
            // 
            this.sortOriginalButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortOriginalButton.Location = new System.Drawing.Point(29, 963);
            this.sortOriginalButton.Name = "sortOriginalButton";
            this.sortOriginalButton.Size = new System.Drawing.Size(222, 65);
            this.sortOriginalButton.TabIndex = 27;
            this.sortOriginalButton.Text = "Sort Restaurants by Original Rating ";
            this.sortOriginalButton.UseVisualStyleBackColor = true;
            // 
            // sortMyRatingButton
            // 
            this.sortMyRatingButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortMyRatingButton.Location = new System.Drawing.Point(259, 963);
            this.sortMyRatingButton.Name = "sortMyRatingButton";
            this.sortMyRatingButton.Size = new System.Drawing.Size(222, 65);
            this.sortMyRatingButton.TabIndex = 28;
            this.sortMyRatingButton.Text = "Sort Restaurants by My Rating";
            this.sortMyRatingButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("JetBrains Mono Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(949, 963);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(222, 65);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete Restaurant";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // footNote
            // 
            this.footNote.AutoSize = true;
            this.footNote.Font = new System.Drawing.Font("JetBrains Mono Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.footNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.footNote.Location = new System.Drawing.Point(940, 1034);
            this.footNote.Name = "footNote";
            this.footNote.Size = new System.Drawing.Size(231, 14);
            this.footNote.TabIndex = 30;
            this.footNote.Text = "ITU BLG317E Group Project | 2024";
            this.footNote.Click += new System.EventHandler(this.footNote_Click);
            // 
            // RestaurantLister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1196, 1057);
            this.Controls.Add(this.footNote);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.sortMyRatingButton);
            this.Controls.Add(this.sortOriginalButton);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.markAsVisitedButton);
            this.Controls.Add(this.addToMyListButton);
            this.Controls.Add(this.myListLabel);
            this.Controls.Add(this.myListGrid);
            this.Controls.Add(this.restaurantGridLabel);
            this.Controls.Add(this.filterMyListButton);
            this.Controls.Add(this.filterRestaurantsButton);
            this.Controls.Add(this.restaurantGrid);
            this.Controls.Add(this.ratingLabelTo);
            this.Controls.Add(this.ratingLabelFrom);
            this.Controls.Add(this.ratingPickerTo);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.cuisineLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.ratingPickerFrom);
            this.Controls.Add(this.cuisinePicker);
            this.Controls.Add(this.cityPicker);
            this.Controls.Add(this.countryPicker);
            this.Controls.Add(this.programLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestaurantLister";
            this.Text = "Restaurant Lister";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label programLabel;
        private ComboBox countryPicker;
        private ComboBox cityPicker;
        private ComboBox cuisinePicker;
        private ComboBox ratingPickerFrom;
        private Label countryLabel;
        private Label cityLabel;
        private Label cuisineLabel;
        private Label ratingLabel;
        private ComboBox ratingPickerTo;
        private Label ratingLabelFrom;
        private Label ratingLabelTo;
        private DataGridView restaurantGrid;
        private Button filterRestaurantsButton;
        private Button filterMyListButton;
        private Label restaurantGridLabel;
        private DataGridView myListGrid;
        private Label myListLabel;
        private Button addToMyListButton;
        private Button markAsVisitedButton;
        private Button rateButton;
        private Button sortOriginalButton;
        private Button sortMyRatingButton;
        private Button deleteButton;
        private Label footNote;
    }
}