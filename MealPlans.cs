using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Bite
{
    public partial class MealPlans : Form
    {
        private ShoppingList list = new ShoppingList();
        private MealPlans plans = new MealPlans();
        private Home home = new Home();
        private Favourites favourites = new Favourites();
        private Recipies recipies = new Recipies();
        private ViewRecipie view = new ViewRecipie();
        private AddMealPlan addPlan = new AddMealPlan();
        private EditMealPlan editPlan = new EditMealPlan();
        public MealPlans()
        {
            InitializeComponent();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            this.Hide();
            favourites.Show();
        }

        private void btnMealPlan_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }

        private void btnRecipie_Click(object sender, EventArgs e)
        {
            this.Hide();
            recipies.Show();
        }

        private void btnShoppingList_Click(object sender, EventArgs e)
        {
            this.Hide();
            list.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            addPlan.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            editPlan.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklblView6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            view.Show();
        }

        private void linklblView7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            view.Show();
        }

        private void linklblView8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            view.Show();
        }

        private void linklblView9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            view.Show();
        }
    }
}
