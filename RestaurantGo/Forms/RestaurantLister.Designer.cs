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
            programLabel = new Label();
            countryPicker = new ComboBox();
            cityPicker = new ComboBox();
            cuisinePicker = new ComboBox();
            ratingPickerFrom = new ComboBox();
            countryLabel = new Label();
            cityLabel = new Label();
            cuisineLabel = new Label();
            ratingLabel = new Label();
            ratingPickerTo = new ComboBox();
            ratingLabelFrom = new Label();
            ratingLabelTo = new Label();
            restaurantGrid = new DataGridView();
            filterRestaurantsButton = new Button();
            filterMyListButton = new Button();
            restaurantGridLabel = new Label();
            myListGrid = new DataGridView();
            myListLabel = new Label();
            addToMyListButton = new Button();
            markAsVisitedButton = new Button();
            rateButton = new Button();
            sortOriginalButton = new Button();
            sortMyRatingButton = new Button();
            deleteButton = new Button();
            footNote = new Label();
            ((System.ComponentModel.ISupportInitialize)restaurantGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myListGrid).BeginInit();
            SuspendLayout();
            // 
            // programLabel
            // 
            programLabel.Font = new Font("Microsoft Sans Serif", 47.99999F, FontStyle.Bold, GraphicsUnit.Point);
            programLabel.ForeColor = Color.White;
            programLabel.Location = new Point(29, 9);
            programLabel.Name = "programLabel";
            programLabel.Size = new Size(1142, 78);
            programLabel.TabIndex = 0;
            programLabel.Text = "Restaurant Lister";
            programLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countryPicker
            // 
            countryPicker.FormattingEnabled = true;
            countryPicker.Location = new Point(29, 116);
            countryPicker.Name = "countryPicker";
            countryPicker.Size = new Size(364, 23);
            countryPicker.TabIndex = 1;
            // 
            // cityPicker
            // 
            cityPicker.FormattingEnabled = true;
            cityPicker.Location = new Point(29, 179);
            cityPicker.Name = "cityPicker";
            cityPicker.Size = new Size(364, 23);
            cityPicker.TabIndex = 2;
            // 
            // cuisinePicker
            // 
            cuisinePicker.FormattingEnabled = true;
            cuisinePicker.Location = new Point(29, 241);
            cuisinePicker.Name = "cuisinePicker";
            cuisinePicker.Size = new Size(364, 23);
            cuisinePicker.TabIndex = 3;
            // 
            // ratingPickerFrom
            // 
            ratingPickerFrom.FormattingEnabled = true;
            ratingPickerFrom.Location = new Point(123, 315);
            ratingPickerFrom.Name = "ratingPickerFrom";
            ratingPickerFrom.Size = new Size(81, 23);
            ratingPickerFrom.TabIndex = 4;
            // 
            // countryLabel
            // 
            countryLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            countryLabel.ForeColor = Color.White;
            countryLabel.Location = new Point(29, 87);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(364, 23);
            countryLabel.TabIndex = 5;
            countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            cityLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cityLabel.ForeColor = Color.White;
            cityLabel.Location = new Point(29, 150);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(364, 23);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City";
            // 
            // cuisineLabel
            // 
            cuisineLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cuisineLabel.ForeColor = Color.White;
            cuisineLabel.Location = new Point(29, 212);
            cuisineLabel.Name = "cuisineLabel";
            cuisineLabel.Size = new Size(364, 23);
            cuisineLabel.TabIndex = 7;
            cuisineLabel.Text = "Cuisine";
            // 
            // ratingLabel
            // 
            ratingLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ratingLabel.ForeColor = Color.White;
            ratingLabel.Location = new Point(29, 277);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(364, 23);
            ratingLabel.TabIndex = 8;
            ratingLabel.Text = "Rating";
            // 
            // ratingPickerTo
            // 
            ratingPickerTo.FormattingEnabled = true;
            ratingPickerTo.Location = new Point(269, 314);
            ratingPickerTo.Name = "ratingPickerTo";
            ratingPickerTo.Size = new Size(81, 23);
            ratingPickerTo.TabIndex = 9;
            // 
            // ratingLabelFrom
            // 
            ratingLabelFrom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ratingLabelFrom.ForeColor = Color.White;
            ratingLabelFrom.Location = new Point(64, 315);
            ratingLabelFrom.Name = "ratingLabelFrom";
            ratingLabelFrom.Size = new Size(53, 23);
            ratingLabelFrom.TabIndex = 10;
            ratingLabelFrom.Text = "From:";
            ratingLabelFrom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ratingLabelTo
            // 
            ratingLabelTo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ratingLabelTo.ForeColor = Color.White;
            ratingLabelTo.Location = new Point(210, 314);
            ratingLabelTo.Name = "ratingLabelTo";
            ratingLabelTo.Size = new Size(53, 23);
            ratingLabelTo.TabIndex = 11;
            ratingLabelTo.Text = "To:";
            ratingLabelTo.TextAlign = ContentAlignment.MiddleRight;
            ratingLabelTo.Click += label2_Click;
            // 
            // restaurantGrid
            // 
            restaurantGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            restaurantGrid.BackgroundColor = Color.White;
            restaurantGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            restaurantGrid.Location = new Point(420, 116);
            restaurantGrid.Name = "restaurantGrid";
            restaurantGrid.RowTemplate.Height = 25;
            restaurantGrid.Size = new Size(751, 481);
            restaurantGrid.TabIndex = 12;
            // 
            // filterRestaurantsButton
            // 
            filterRestaurantsButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterRestaurantsButton.Location = new Point(29, 360);
            filterRestaurantsButton.Name = "filterRestaurantsButton";
            filterRestaurantsButton.Size = new Size(364, 65);
            filterRestaurantsButton.TabIndex = 13;
            filterRestaurantsButton.Text = "List Restaurants with Selected Filters";
            filterRestaurantsButton.UseVisualStyleBackColor = true;
            // 
            // filterMyListButton
            // 
            filterMyListButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterMyListButton.Location = new Point(29, 446);
            filterMyListButton.Name = "filterMyListButton";
            filterMyListButton.Size = new Size(364, 65);
            filterMyListButton.TabIndex = 14;
            filterMyListButton.Text = "Apply Selected Filters to My List";
            filterMyListButton.UseVisualStyleBackColor = true;
            // 
            // restaurantGridLabel
            // 
            restaurantGridLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            restaurantGridLabel.ForeColor = Color.White;
            restaurantGridLabel.Location = new Point(420, 87);
            restaurantGridLabel.Name = "restaurantGridLabel";
            restaurantGridLabel.Size = new Size(751, 23);
            restaurantGridLabel.TabIndex = 16;
            restaurantGridLabel.Text = "Restaurants";
            // 
            // myListGrid
            // 
            myListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            myListGrid.BackgroundColor = Color.White;
            myListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myListGrid.Location = new Point(29, 643);
            myListGrid.Name = "myListGrid";
            myListGrid.RowTemplate.Height = 25;
            myListGrid.Size = new Size(1142, 308);
            myListGrid.TabIndex = 17;
            // 
            // myListLabel
            // 
            myListLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            myListLabel.ForeColor = Color.White;
            myListLabel.ImageAlign = ContentAlignment.MiddleRight;
            myListLabel.Location = new Point(29, 614);
            myListLabel.Name = "myListLabel";
            myListLabel.Size = new Size(1142, 23);
            myListLabel.TabIndex = 18;
            myListLabel.Text = "My List";
            myListLabel.TextAlign = ContentAlignment.TopCenter;
            myListLabel.Click += myListLabel_Click;
            // 
            // addToMyListButton
            // 
            addToMyListButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addToMyListButton.Location = new Point(29, 532);
            addToMyListButton.Name = "addToMyListButton";
            addToMyListButton.Size = new Size(364, 65);
            addToMyListButton.TabIndex = 22;
            addToMyListButton.Text = "Add Selected Restaurants to My List";
            addToMyListButton.UseVisualStyleBackColor = true;
            // 
            // markAsVisitedButton
            // 
            markAsVisitedButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            markAsVisitedButton.Location = new Point(489, 963);
            markAsVisitedButton.Name = "markAsVisitedButton";
            markAsVisitedButton.Size = new Size(222, 65);
            markAsVisitedButton.TabIndex = 25;
            markAsVisitedButton.Text = "Mark as Visited";
            markAsVisitedButton.UseVisualStyleBackColor = true;
            // 
            // rateButton
            // 
            rateButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rateButton.Location = new Point(719, 963);
            rateButton.Name = "rateButton";
            rateButton.Size = new Size(222, 65);
            rateButton.TabIndex = 26;
            rateButton.Text = "Rate Restaurant";
            rateButton.UseVisualStyleBackColor = true;
            // 
            // sortOriginalButton
            // 
            sortOriginalButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sortOriginalButton.Location = new Point(29, 963);
            sortOriginalButton.Name = "sortOriginalButton";
            sortOriginalButton.Size = new Size(222, 65);
            sortOriginalButton.TabIndex = 27;
            sortOriginalButton.Text = "Sort Restaurants by Original Rating ";
            sortOriginalButton.UseVisualStyleBackColor = true;
            // 
            // sortMyRatingButton
            // 
            sortMyRatingButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sortMyRatingButton.Location = new Point(259, 963);
            sortMyRatingButton.Name = "sortMyRatingButton";
            sortMyRatingButton.Size = new Size(222, 65);
            sortMyRatingButton.TabIndex = 28;
            sortMyRatingButton.Text = "Sort Restaurants by My Rating";
            sortMyRatingButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(949, 963);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(222, 65);
            deleteButton.TabIndex = 29;
            deleteButton.Text = "Delete Restaurant";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // footNote
            // 
            footNote.AutoSize = true;
            footNote.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            footNote.ForeColor = Color.FromArgb(25, 25, 25);
            footNote.Location = new Point(940, 1034);
            footNote.Name = "footNote";
            footNote.Size = new Size(174, 13);
            footNote.TabIndex = 30;
            footNote.Text = "ITU BLG317E Group Project | 2024";
            footNote.Click += footNote_Click;
            // 
            // RestaurantLister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(1222, 1037);
            Controls.Add(footNote);
            Controls.Add(deleteButton);
            Controls.Add(sortMyRatingButton);
            Controls.Add(sortOriginalButton);
            Controls.Add(rateButton);
            Controls.Add(markAsVisitedButton);
            Controls.Add(addToMyListButton);
            Controls.Add(myListLabel);
            Controls.Add(myListGrid);
            Controls.Add(restaurantGridLabel);
            Controls.Add(filterMyListButton);
            Controls.Add(filterRestaurantsButton);
            Controls.Add(restaurantGrid);
            Controls.Add(ratingLabelTo);
            Controls.Add(ratingLabelFrom);
            Controls.Add(ratingPickerTo);
            Controls.Add(ratingLabel);
            Controls.Add(cuisineLabel);
            Controls.Add(cityLabel);
            Controls.Add(countryLabel);
            Controls.Add(ratingPickerFrom);
            Controls.Add(cuisinePicker);
            Controls.Add(cityPicker);
            Controls.Add(countryPicker);
            Controls.Add(programLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RestaurantLister";
            Text = "Restaurant Lister";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)restaurantGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)myListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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