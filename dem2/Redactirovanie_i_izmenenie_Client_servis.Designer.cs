namespace dem2
{
    partial class Redactirovanie_i_izmenenie_Client_servis
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
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label Nazad;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redactirovanie_i_izmenenie_Client_servis));
            this.___Dem2SkaredinDataSet = new dem2.@__Dem2SkaredinDataSet();
            this.clientServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientServiceTableAdapter = new dem2.@__Dem2SkaredinDataSetTableAdapters.ClientServiceTableAdapter();
            this.tableAdapterManager = new dem2.@__Dem2SkaredinDataSetTableAdapters.TableAdapterManager();
            this.clientServiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientServiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.serviceIDTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            clientIDLabel = new System.Windows.Forms.Label();
            serviceIDLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            Nazad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2SkaredinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingNavigator)).BeginInit();
            this.clientServiceBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(27, 73);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 3;
            clientIDLabel.Text = "Client ID:";
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Location = new System.Drawing.Point(27, 99);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(60, 13);
            serviceIDLabel.TabIndex = 5;
            serviceIDLabel.Text = "Service ID:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(27, 126);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 7;
            startTimeLabel.Text = "Start Time:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(27, 151);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 9;
            commentLabel.Text = "Comment:";
            // 
            // Nazad
            // 
            Nazad.AutoSize = true;
            Nazad.ForeColor = System.Drawing.Color.OrangeRed;
            Nazad.Location = new System.Drawing.Point(24, 38);
            Nazad.Name = "Nazad";
            Nazad.Size = new System.Drawing.Size(22, 13);
            Nazad.TabIndex = 19;
            Nazad.Text = "<---";
            Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // ___Dem2SkaredinDataSet
            // 
            this.___Dem2SkaredinDataSet.DataSetName = "__Dem2SkaredinDataSet";
            this.___Dem2SkaredinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientServiceBindingSource
            // 
            this.clientServiceBindingSource.DataMember = "ClientService";
            this.clientServiceBindingSource.DataSource = this.___Dem2SkaredinDataSet;
            // 
            // clientServiceTableAdapter
            // 
            this.clientServiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachedProductTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = this.clientServiceTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DocumentByServiceTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicePhotoTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TagOfClientTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dem2.@__Dem2SkaredinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientServiceBindingNavigator
            // 
            this.clientServiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientServiceBindingNavigator.BindingSource = this.clientServiceBindingSource;
            this.clientServiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientServiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientServiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientServiceBindingNavigatorSaveItem});
            this.clientServiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientServiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientServiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientServiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientServiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientServiceBindingNavigator.Name = "clientServiceBindingNavigator";
            this.clientServiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientServiceBindingNavigator.Size = new System.Drawing.Size(326, 25);
            this.clientServiceBindingNavigator.TabIndex = 0;
            this.clientServiceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clientServiceBindingNavigatorSaveItem
            // 
            this.clientServiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientServiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientServiceBindingNavigatorSaveItem.Image")));
            this.clientServiceBindingNavigatorSaveItem.Name = "clientServiceBindingNavigatorSaveItem";
            this.clientServiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientServiceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.clientServiceBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientServiceBindingNavigatorSaveItem_Click);
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientServiceBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(93, 70);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientIDTextBox.TabIndex = 4;
            // 
            // serviceIDTextBox
            // 
            this.serviceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientServiceBindingSource, "ServiceID", true));
            this.serviceIDTextBox.Location = new System.Drawing.Point(93, 96);
            this.serviceIDTextBox.Name = "serviceIDTextBox";
            this.serviceIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.serviceIDTextBox.TabIndex = 6;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientServiceBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(93, 122);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimeDateTimePicker.TabIndex = 8;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientServiceBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(93, 148);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 20);
            this.commentTextBox.TabIndex = 10;
            // 
            // Redactirovanie_i_izmenenie_Client_servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 184);
            this.Controls.Add(Nazad);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(serviceIDLabel);
            this.Controls.Add(this.serviceIDTextBox);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeDateTimePicker);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.clientServiceBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Redactirovanie_i_izmenenie_Client_servis";
            this.Text = "Redactirovanie_i_izmenenie_Client_servis";
            this.Load += new System.EventHandler(this.Redactirovanie_i_izmenenie_Client_servis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2SkaredinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingNavigator)).EndInit();
            this.clientServiceBindingNavigator.ResumeLayout(false);
            this.clientServiceBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private __Dem2SkaredinDataSet ___Dem2SkaredinDataSet;
        private System.Windows.Forms.BindingSource clientServiceBindingSource;
        private __Dem2SkaredinDataSetTableAdapters.ClientServiceTableAdapter clientServiceTableAdapter;
        private __Dem2SkaredinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientServiceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientServiceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox serviceIDTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
    }
}