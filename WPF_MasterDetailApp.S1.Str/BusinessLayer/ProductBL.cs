using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS
        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;


        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS
        public ProductBL()
        {
            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        private Product GetProductData()
        {
            return new Product()
            {
                FirstName = "Lydia",
                LastName = "Yngram",
                Gender = Product.GenderType.female,
                Race = "Nord",
                Service = "HouseCarl",
                Ranking = "Warrior",
                ImageFileName = "Lydia.jpg"
            };
        }

        private Company GetCompanyData()
        {
             Company company = new Company();

            company.Name = "Gold Coast Mercinaries";
            company.Address = "The Docks";
            company.City = "Solitude";

            return company;
        }


        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
