using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest3
{
    //Inherit from Subscription
    public class PrintSubscription : Subscription
    {
        #region CONSTANTS

        private const decimal SHIPPING_RATE = 0.02m;
        private const decimal ECO_TAX = 0.01m;
        private const int MAILING_ADDRESS_MAX_LENGTH = 50;

        #endregion

        #region FIELDS

        private string mailingAddress;
        private string city;
        private string province;
        private string postalCode;

        #endregion

        #region CONSTRUCTORS

        public PrintSubscription(string firstName, string lastName, string mailingAddress,
            string city, string province, string postalCode) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.mailingAddress = mailingAddress;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
        }

        #endregion

        #region Properties

        public string MailingAddress
        {
            get { return mailingAddress; }
            set
            {
                if (!Validate.ValidLessThanLength(value, MAILING_ADDRESS_MAX_LENGTH))
                {
                    throw new ArgumentException("Invalid Mailing Address");
                }
                mailingAddress = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (!Validate.ValidNotEmpty(value))
                {
                    throw new ArgumentException("Invalid City");
                }
                city = value;
            }
        }

        public string Province
        {
            get { return province; }
            set
            {
                if (!Validate.ValidNotEmpty(value))
                {
                    throw new ArgumentException("Invalid Province");
                }
                province = value;
            }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set
            {
                if (!Validate.IsValidPostalCode(value))
                {
                    throw new ArgumentException("Postal code is not valid");
                }
                postalCode = value;
            }
        }

        #endregion

        #region METHODS

        public override decimal CalculateSubscriptionPrice()
        {
            return base.CalculateSubscriptionPrice() * (1.0m + SHIPPING_RATE);
        }

        public override void AddPublication(Publication publication)
        {
            if (!CanAddPublication(publication))
            {
                throw new ArgumentException("Cannot order copies");
            }
            else
            {
                publication.IssuePrice = publication.IssuePrice * (1 + ECO_TAX);

                Publications.Add(publication);
            }
        }

        #endregion

    }
}
