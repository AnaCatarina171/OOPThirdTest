using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest3
{
    public abstract class Subscription
    {

        #region CONSTANTS

        private const decimal TAX_RATE = 0.15m;
        private const int NAME_MIN_LENGTH = 2;

        #endregion

        #region FIELDS

        private string firstName;
        private string lastName;

        #endregion

        #region CONSTRUCTORS

        public Subscription(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        #endregion

        #region PROPERTIES

        protected List<Publication> Publications { get; } = new List<Publication>();


        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!Validate.ValidGreaterThanLength(value, 1))
                {
                    throw new ArgumentException("Invalid First Name");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!Validate.ValidGreaterThanLength(value, 1))
                {
                    throw new ArgumentException("Invalid Last Name");
                }
                lastName = value;
            }
        }

        #endregion

        #region METHODS

        protected bool CanAddPublication(Publication publication)
        {
            foreach (var pub in Publications)
            {
                if (pub.PublicationName == publication.PublicationName &&
                    pub.VolumeNumber == publication.VolumeNumber &&
                    pub.IssueNumber == publication.IssueNumber &&
                    pub.Media == publication.Media)
                {
                    return false;
                }
            }

            return true;
        }


        public abstract void AddPublication(Publication publication);

        public static List<int> OrderableVolumes()
        {
            return new List<int>() { DateTime.Now.Year - 1, DateTime.Now.Year, DateTime.Now.Year + 1 };
        }

        public virtual decimal CalculateSubscriptionPrice()
        {
            decimal totalIssuePrice = 0;

            foreach (var pub in Publications)
            {
                totalIssuePrice += pub.IssuePrice;
            }

            return totalIssuePrice * (1 + TAX_RATE);
        }

        #endregion
    }
}
