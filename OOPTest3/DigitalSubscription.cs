using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest3
{
    //Inherit from Subscription
    public class DigitalSubscription : Subscription
    {
        #region CONSTANTS

        private const decimal CONSECUTIVE_ISSUE_DISCOUNT_RATE = 0.10m;

        #endregion

        #region[FIELDS

        private string emailAddress;

        #endregion

        #region CONSTRUCTORS

        public DigitalSubscription(string firstName, string lastName, string emailAddress) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.emailAddress = emailAddress;
        }

        #endregion

        #region PROPERTIES

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if (!Validate.IsValidEmail(value))
                    throw new ArgumentException("Email address is invalid");

                emailAddress = value;
            }
        }

        #endregion

        #region METHODS

        public override void AddPublication(Publication publication)
        {
            //int equalVolumePublications = 0;

            if (!CanAddPublication(publication))
            {
                throw new ArgumentException("Cannot order copies");
            }
            else
            {
                if (Publications.Count > 6)
                {
                    publication.IssuePrice = publication.IssuePrice * (1 - CONSECUTIVE_ISSUE_DISCOUNT_RATE);
                }

                /*foreach (var pub in Publications)
                {

                }*/

                Publications.Add(publication);
            }
        }

        #endregion
    }
}
