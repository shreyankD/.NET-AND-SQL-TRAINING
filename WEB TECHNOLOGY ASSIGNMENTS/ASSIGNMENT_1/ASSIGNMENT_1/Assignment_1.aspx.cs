using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class ASSIGNMENT_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the dropdown list with items
                ddlItems.Items.Add(new ListItem("SELECT FROM BELOW", ""));
                ddlItems.Items.Add(new ListItem("biryani", "biryani.jpg"));
                ddlItems.Items.Add(new ListItem("ice cream", "ice cream.jpg"));
                ddlItems.Items.Add(new ListItem("lassi", "lassi.jpg"));
                ddlItems.Items.Add(new ListItem("paneer", "paneer.jpg"));
                ddlItems.Items.Add(new ListItem("paneer_naan", "paneer_naan.jpg"));
            }
        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the image URL based on the selected item
            string selectedImageUrl = ddlItems.SelectedItem.Value;
            imgItem.ImageUrl = $"images/{selectedImageUrl}";
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            // Get the cost of the selected item (You can replace this with your actual cost logic)
            string selectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            lblCost.Text = $"Cost of {selectedItem}: {cost}";
        }

        // You can implement your own cost retrieval logic here
        private string GetItemCost(string item)
        {
            // Replace this with your cost retrieval logic
            switch (item)
            {
                case "biryani":
                    return "Rs 180";
                case "ice cream":
                    return "Rs 90";
                case "lassi":
                    return "Rs 40";
                case "paneer":
                    return "Rs 220";
                case "paneer_naan":
                    return "Rs 300";
                default:
                    return "N/A";
            }
        }

    }
}