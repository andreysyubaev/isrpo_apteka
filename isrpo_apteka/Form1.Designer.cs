namespace isrpo_apteka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.buttonSoft = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonAerozole = new System.Windows.Forms.Button();
            this.buttonLiquid = new System.Windows.Forms.Button();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.labelCaterory = new System.Windows.Forms.Label();
            this.buttonArrowLeft = new System.Windows.Forms.Button();
            this.buttonArrowRight = new System.Windows.Forms.Button();
            this.buttonSearchCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(11, 8);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(97, 31);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(14, 41);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(497, 32);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(132, 324);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(137, 31);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Название";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(132, 356);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(64, 26);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImage.Location = new System.Drawing.Point(14, 324);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(114, 114);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 5;
            this.pictureBoxImage.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 199);
            this.dataGridView1.TabIndex = 8;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(135, 386);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Описание";
            // 
            // labelForm
            // 
            this.labelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForm.Location = new System.Drawing.Point(591, 326);
            this.labelForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(213, 31);
            this.labelForm.TabIndex = 10;
            this.labelForm.Text = "Форма выпуска";
            // 
            // buttonSoft
            // 
            this.buttonSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSoft.Location = new System.Drawing.Point(699, 359);
            this.buttonSoft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSoft.Name = "buttonSoft";
            this.buttonSoft.Size = new System.Drawing.Size(103, 41);
            this.buttonSoft.TabIndex = 11;
            this.buttonSoft.Text = "Мягкие";
            this.buttonSoft.UseVisualStyleBackColor = true;
            // 
            // buttonHard
            // 
            this.buttonHard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHard.Location = new System.Drawing.Point(597, 359);
            this.buttonHard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(103, 41);
            this.buttonHard.TabIndex = 12;
            this.buttonHard.Text = "Твердые";
            this.buttonHard.UseVisualStyleBackColor = true;
            // 
            // buttonAerozole
            // 
            this.buttonAerozole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAerozole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAerozole.Location = new System.Drawing.Point(597, 398);
            this.buttonAerozole.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAerozole.Name = "buttonAerozole";
            this.buttonAerozole.Size = new System.Drawing.Size(103, 41);
            this.buttonAerozole.TabIndex = 13;
            this.buttonAerozole.Text = "Аэрозоли";
            this.buttonAerozole.UseVisualStyleBackColor = true;
            // 
            // buttonLiquid
            // 
            this.buttonLiquid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLiquid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLiquid.Location = new System.Drawing.Point(699, 398);
            this.buttonLiquid.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLiquid.Name = "buttonLiquid";
            this.buttonLiquid.Size = new System.Drawing.Size(103, 41);
            this.buttonLiquid.TabIndex = 14;
            this.buttonLiquid.Text = "Жидкие";
            this.buttonLiquid.UseVisualStyleBackColor = true;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(515, 39);
            this.listBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(356, 238);
            this.listBoxCategory.TabIndex = 15;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // labelCaterory
            // 
            this.labelCaterory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCaterory.AutoSize = true;
            this.labelCaterory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaterory.Location = new System.Drawing.Point(618, 6);
            this.labelCaterory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaterory.Name = "labelCaterory";
            this.labelCaterory.Size = new System.Drawing.Size(153, 31);
            this.labelCaterory.TabIndex = 16;
            this.labelCaterory.Text = "Категории";
            // 
            // buttonArrowLeft
            // 
            this.buttonArrowLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArrowLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArrowLeft.Location = new System.Drawing.Point(14, 282);
            this.buttonArrowLeft.Name = "buttonArrowLeft";
            this.buttonArrowLeft.Size = new System.Drawing.Size(246, 34);
            this.buttonArrowLeft.TabIndex = 17;
            this.buttonArrowLeft.Text = "<<";
            this.buttonArrowLeft.UseVisualStyleBackColor = true;
            this.buttonArrowLeft.Click += new System.EventHandler(this.buttonArrowLeft_Click);
            // 
            // buttonArrowRight
            // 
            this.buttonArrowRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArrowRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArrowRight.Location = new System.Drawing.Point(265, 282);
            this.buttonArrowRight.Name = "buttonArrowRight";
            this.buttonArrowRight.Size = new System.Drawing.Size(246, 34);
            this.buttonArrowRight.TabIndex = 18;
            this.buttonArrowRight.Text = ">>";
            this.buttonArrowRight.UseVisualStyleBackColor = true;
            this.buttonArrowRight.Click += new System.EventHandler(this.buttonArrowRight_Click);
            // 
            // buttonSearchCategory
            // 
            this.buttonSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchCategory.Location = new System.Drawing.Point(515, 282);
            this.buttonSearchCategory.Name = "buttonSearchCategory";
            this.buttonSearchCategory.Size = new System.Drawing.Size(356, 34);
            this.buttonSearchCategory.TabIndex = 19;
            this.buttonSearchCategory.Text = "Найти";
            this.buttonSearchCategory.UseVisualStyleBackColor = true;
            this.buttonSearchCategory.Click += new System.EventHandler(this.buttonSearchCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 449);
            this.Controls.Add(this.buttonSearchCategory);
            this.Controls.Add(this.buttonArrowRight);
            this.Controls.Add(this.buttonArrowLeft);
            this.Controls.Add(this.labelCaterory);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.buttonLiquid);
            this.Controls.Add(this.buttonAerozole);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonSoft);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.pictureBoxImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Аптека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Button buttonSoft;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonAerozole;
        private System.Windows.Forms.Button buttonLiquid;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Label labelCaterory;
        private System.Windows.Forms.Button buttonArrowLeft;
        private System.Windows.Forms.Button buttonArrowRight;
        private System.Windows.Forms.Button buttonSearchCategory;
    }
}

