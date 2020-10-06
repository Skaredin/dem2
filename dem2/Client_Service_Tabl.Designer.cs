namespace dem2
{
    partial class Client_Service_Tabl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Service_Tabl));
            System.Windows.Forms.Label Nazad;
            this.___Dem2SkaredinDataSet = new dem2.@__Dem2SkaredinDataSet();
            this.clientServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientServiceTableAdapter = new dem2.@__Dem2SkaredinDataSetTableAdapters.ClientServiceTableAdapter();
            this.tableAdapterManager = new dem2.@__Dem2SkaredinDataSetTableAdapters.TableAdapterManager();
            this.clientServiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientServiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientServiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izmenenie = new System.Windows.Forms.Button();
            Nazad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2SkaredinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingNavigator)).BeginInit();
            this.clientServiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.clientServiceBindingNavigator.Size = new System.Drawing.Size(822, 25);
            this.clientServiceBindingNavigator.TabIndex = 0;
            this.clientServiceBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // clientServiceDataGridView
            // 
            this.clientServiceDataGridView.AutoGenerateColumns = false;
            this.clientServiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientServiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clientServiceDataGridView.DataSource = this.clientServiceBindingSource;
            this.clientServiceDataGridView.Location = new System.Drawing.Point(12, 118);
            this.clientServiceDataGridView.Name = "clientServiceDataGridView";
            this.clientServiceDataGridView.Size = new System.Drawing.Size(788, 320);
            this.clientServiceDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ServiceID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ServiceID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn5.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // izmenenie
            // 
            this.izmenenie.Location = new System.Drawing.Point(544, 89);
            this.izmenenie.Name = "izmenenie";
            this.izmenenie.Size = new System.Drawing.Size(256, 23);
            this.izmenenie.TabIndex = 2;
            this.izmenenie.Text = "Изменение и редактирование";
            this.izmenenie.UseVisualStyleBackColor = true;
            this.izmenenie.Click += new System.EventHandler(this.izmenenie_Click);
            // 
            // Nazad
            // 
            Nazad.AutoSize = true;
            Nazad.ForeColor = System.Drawing.Color.OrangeRed;
            Nazad.Location = new System.Drawing.Point(22, 39);
            Nazad.Name = "Nazad";
            Nazad.Size = new System.Drawing.Size(22, 13);
            Nazad.TabIndex = 18;
            Nazad.Text = "<---";
            Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Client_Service_Tabl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(Nazad);
            this.Controls.Add(this.izmenenie);
            this.Controls.Add(this.clientServiceDataGridView);
            this.Controls.Add(this.clientServiceBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_Service_Tabl";
            this.Text = "Client_Service_Tabl";
            this.Load += new System.EventHandler(this.Client_Service_Tabl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2SkaredinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceBindingNavigator)).EndInit();
            this.clientServiceBindingNavigator.ResumeLayout(false);
            this.clientServiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientServiceDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView clientServiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button izmenenie;
    }
}