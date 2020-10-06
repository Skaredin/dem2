namespace dem2
{
    partial class Redaktirovanie_i_izmenenie
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label durationInSecondsLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label mainImagePathLabel;
            System.Windows.Forms.Label Nazad;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redaktirovanie_i_izmenenie));
            this.___Dem2SkaredinDataSet = new dem2.@__Dem2SkaredinDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new dem2.@__Dem2SkaredinDataSetTableAdapters.ServiceTableAdapter();
            this.tableAdapterManager = new dem2.@__Dem2SkaredinDataSetTableAdapters.TableAdapterManager();
            this.serviceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.serviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.durationInSecondsTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.mainImagePathTextBox = new System.Windows.Forms.TextBox();
            this.kartinka = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            durationInSecondsLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            mainImagePathLabel = new System.Windows.Forms.Label();
            Nazad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2SkaredinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).BeginInit();
            this.serviceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartinka)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(23, 87);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(23, 113);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 5;
            costLabel.Text = "Cost:";
            // 
            // durationInSecondsLabel
            // 
            durationInSecondsLabel.AutoSize = true;
            durationInSecondsLabel.Location = new System.Drawing.Point(23, 139);
            durationInSecondsLabel.Name = "durationInSecondsLabel";
            durationInSecondsLabel.Size = new System.Drawing.Size(107, 13);
            durationInSecondsLabel.TabIndex = 7;
            durationInSecondsLabel.Text = "Duration In Seconds:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(23, 165);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(23, 191);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(52, 13);
            discountLabel.TabIndex = 11;
            discountLabel.Text = "Discount:";
            // 
            // mainImagePathLabel
            // 
            mainImagePathLabel.AutoSize = true;
            mainImagePathLabel.Location = new System.Drawing.Point(23, 217);
            mainImagePathLabel.Name = "mainImagePathLabel";
            mainImagePathLabel.Size = new System.Drawing.Size(90, 13);
            mainImagePathLabel.TabIndex = 13;
            mainImagePathLabel.Text = "Main Image Path:";
            // 
            // Nazad
            // 
            Nazad.AutoSize = true;
            Nazad.ForeColor = System.Drawing.Color.OrangeRed;
            Nazad.Location = new System.Drawing.Point(23, 46);
            Nazad.Name = "Nazad";
            Nazad.Size = new System.Drawing.Size(22, 13);
            Nazad.TabIndex = 18;
            Nazad.Text = "<---";
            Nazad.Click += new System.EventHandler(this.Nazad_Click_1);
            // 
            // ___Dem2SkaredinDataSet
            // 
            this.___Dem2SkaredinDataSet.DataSetName = "__Dem2SkaredinDataSet";
            this.___Dem2SkaredinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.___Dem2SkaredinDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachedProductTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DocumentByServiceTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicePhotoTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager.TagOfClientTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dem2.@__Dem2SkaredinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviceBindingNavigator
            // 
            this.serviceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviceBindingNavigator.BindingSource = this.serviceBindingSource;
            this.serviceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.serviceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.serviceBindingNavigatorSaveItem});
            this.serviceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.serviceBindingNavigator.MoveFirstItem = null;
            this.serviceBindingNavigator.MoveLastItem = null;
            this.serviceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviceBindingNavigator.Name = "serviceBindingNavigator";
            this.serviceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviceBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.serviceBindingNavigator.TabIndex = 0;
            this.serviceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // serviceBindingNavigatorSaveItem
            // 
            this.serviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceBindingNavigatorSaveItem.Image")));
            this.serviceBindingNavigatorSaveItem.Name = "serviceBindingNavigatorSaveItem";
            this.serviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.serviceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.serviceBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviceBindingNavigatorSaveItem_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(136, 84);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(136, 110);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 6;
            // 
            // durationInSecondsTextBox
            // 
            this.durationInSecondsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "DurationInSeconds", true));
            this.durationInSecondsTextBox.Location = new System.Drawing.Point(136, 136);
            this.durationInSecondsTextBox.Name = "durationInSecondsTextBox";
            this.durationInSecondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationInSecondsTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(136, 162);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(136, 188);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 12;
            // 
            // mainImagePathTextBox
            // 
            this.mainImagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "MainImagePath", true));
            this.mainImagePathTextBox.Location = new System.Drawing.Point(136, 214);
            this.mainImagePathTextBox.Name = "mainImagePathTextBox";
            this.mainImagePathTextBox.Size = new System.Drawing.Size(100, 20);
            this.mainImagePathTextBox.TabIndex = 14;
            // 
            // kartinka
            // 
            this.kartinka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kartinka.Location = new System.Drawing.Point(257, 84);
            this.kartinka.Name = "kartinka";
            this.kartinka.Size = new System.Drawing.Size(592, 447);
            this.kartinka.TabIndex = 15;
            this.kartinka.TabStop = false;
            // 
            // Redaktirovanie_i_izmenenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 573);
            this.Controls.Add(Nazad);
            this.Controls.Add(this.kartinka);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(durationInSecondsLabel);
            this.Controls.Add(this.durationInSecondsTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(mainImagePathLabel);
            this.Controls.Add(this.mainImagePathTextBox);
            this.Controls.Add(this.serviceBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Redaktirovanie_i_izmenenie";
            this.Text = "Redaktirovanie_i_izmenenie";
            this.Load += new System.EventHandler(this.Redaktirovanie_i_izmenenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2SkaredinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).EndInit();
            this.serviceBindingNavigator.ResumeLayout(false);
            this.serviceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private __Dem2SkaredinDataSet ___Dem2SkaredinDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private __Dem2SkaredinDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private __Dem2SkaredinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator serviceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton serviceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox durationInSecondsTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox mainImagePathTextBox;
        private System.Windows.Forms.PictureBox kartinka;
    }
}