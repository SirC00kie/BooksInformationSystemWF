namespace BooksInformationSystem.Views
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboContent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butGetData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textYearSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textAuthorSeacrh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textNameSearch = new System.Windows.Forms.TextBox();
            this.clearGrid = new System.Windows.Forms.Button();
            this.deleteGrid = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenu,
            this.saveMenu});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // loadMenu
            // 
            this.loadMenu.Name = "loadMenu";
            this.loadMenu.Size = new System.Drawing.Size(166, 26);
            this.loadMenu.Text = "Загрузить";
            this.loadMenu.Click += new System.EventHandler(this.loadMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(166, 26);
            this.saveMenu.Text = "Сохранить";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(187, 26);
            this.aboutMenu.Text = "О программе";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.comboContent);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textAuthor);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textYear);
            this.tabPage1.Controls.Add(this.textDescription);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(900, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление эл. пособия";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(476, 392);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(177, 51);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(694, 392);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(177, 51);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboContent
            // 
            this.comboContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContent.FormattingEnabled = true;
            this.comboContent.Location = new System.Drawing.Point(325, 145);
            this.comboContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboContent.Name = "comboContent";
            this.comboContent.Size = new System.Drawing.Size(351, 28);
            this.comboContent.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Тематика публикации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Тип публикации";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(325, 49);
            this.comboType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(351, 28);
            this.comboType.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Автор";
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(325, 216);
            this.textAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAuthor.MaxLength = 128;
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(351, 27);
            this.textAuthor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год публикации";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(325, 286);
            this.textYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textYear.MaxLength = 4;
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(351, 27);
            this.textYear.TabIndex = 5;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(18, 140);
            this.textDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDescription.MaxLength = 128;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(269, 186);
            this.textDescription.TabIndex = 4;
            this.textDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(19, 49);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textName.MaxLength = 128;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(268, 27);
            this.textName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage2.Controls.Add(this.butGetData);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textYearSearch);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textAuthorSeacrh);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textNameSearch);
            this.tabPage2.Controls.Add(this.clearGrid);
            this.tabPage2.Controls.Add(this.deleteGrid);
            this.tabPage2.Controls.Add(this.dataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(900, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Библиотека эл. пособий";
            // 
            // butGetData
            // 
            this.butGetData.Location = new System.Drawing.Point(275, 403);
            this.butGetData.Name = "butGetData";
            this.butGetData.Size = new System.Drawing.Size(194, 42);
            this.butGetData.TabIndex = 13;
            this.butGetData.Text = "Найти";
            this.butGetData.UseVisualStyleBackColor = true;
            this.butGetData.Click += new System.EventHandler(this.butGetData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Год публикации";
            // 
            // textYearSearch
            // 
            this.textYearSearch.Location = new System.Drawing.Point(473, 358);
            this.textYearSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textYearSearch.MaxLength = 4;
            this.textYearSearch.Name = "textYearSearch";
            this.textYearSearch.Size = new System.Drawing.Size(211, 27);
            this.textYearSearch.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Автор";
            // 
            // textAuthorSeacrh
            // 
            this.textAuthorSeacrh.Location = new System.Drawing.Point(241, 358);
            this.textAuthorSeacrh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAuthorSeacrh.MaxLength = 128;
            this.textAuthorSeacrh.Name = "textAuthorSeacrh";
            this.textAuthorSeacrh.Size = new System.Drawing.Size(210, 27);
            this.textAuthorSeacrh.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Название";
            // 
            // textNameSearch
            // 
            this.textNameSearch.Location = new System.Drawing.Point(17, 358);
            this.textNameSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNameSearch.MaxLength = 128;
            this.textNameSearch.Name = "textNameSearch";
            this.textNameSearch.Size = new System.Drawing.Size(203, 27);
            this.textNameSearch.TabIndex = 3;
            // 
            // clearGrid
            // 
            this.clearGrid.Location = new System.Drawing.Point(711, 403);
            this.clearGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearGrid.Name = "clearGrid";
            this.clearGrid.Size = new System.Drawing.Size(183, 42);
            this.clearGrid.TabIndex = 2;
            this.clearGrid.Text = "Очистить";
            this.clearGrid.UseVisualStyleBackColor = true;
            this.clearGrid.Click += new System.EventHandler(this.clearGrid_Click);
            // 
            // deleteGrid
            // 
            this.deleteGrid.Location = new System.Drawing.Point(711, 343);
            this.deleteGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteGrid.Name = "deleteGrid";
            this.deleteGrid.Size = new System.Drawing.Size(183, 42);
            this.deleteGrid.TabIndex = 1;
            this.deleteGrid.Text = "Удалить запись";
            this.deleteGrid.UseVisualStyleBackColor = true;
            this.deleteGrid.Click += new System.EventHandler(this.deleteGrid_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Location = new System.Drawing.Point(6, 4);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(888, 314);
            this.dataGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Информационная система учета электронных пособий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ToolStripMenuItem loadMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.Button deleteGrid;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button clearGrid;
        private Label label7;
        private TextBox textNameSearch;
        private Button butGetData;
        private Label label9;
        private TextBox textYearSearch;
        private Label label8;
        private TextBox textAuthorSeacrh;
    }
}