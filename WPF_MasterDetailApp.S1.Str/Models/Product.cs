using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS

        public enum GenderType { none, male, female }

        #endregion

        #region FIELDS

        private string _firstName;
        private string _lastName;
        private GenderType _gender;
        private string _imageFileName;
        private string _race;
        private string _service;
        private string _ranking;

        #endregion

        #region PROPERTIES

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;

            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;

            }
        }

        public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }

        public string Ranking
        {
            get { return _ranking; }
            set { _ranking = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}

