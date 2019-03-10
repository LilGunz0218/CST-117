namespace Milestone1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addItem = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Inventory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addItem
            // 
            resources.ApplyResources(this.addItem, "addItem");
            this.addItem.Name = "addItem";
            this.addItem.UseVisualStyleBackColor = true;
            // 
            // RemoveItem
            // 
            resources.ApplyResources(this.RemoveItem, "RemoveItem");
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            resources.ApplyResources(this.SearchButton, "SearchButton");
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchText
            // 
            resources.ApplyResources(this.SearchText, "SearchText");
            this.SearchText.Name = "SearchText";
            // 
            // Inventory
            // 
            resources.ApplyResources(this.Inventory, "Inventory");
            this.Inventory.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.Inventory.FormattingEnabled = true;
            this.Inventory.Name = "Inventory";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // editInventory
            // 
            resources.ApplyResources(this.editInventory, "editInventory");
            this.editInventory.Name = "editInventory";
            this.editInventory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.addItem);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ListBox Inventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editInventory;
    }
}

