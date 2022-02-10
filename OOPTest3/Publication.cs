using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest3
{
    public class Publication
    {
        #region Constants

        private const int MIN_ISSUE_NAME_LENGTH = 5;
        private const int MAX_ISSUES_PER_VOLUME = 12;

        #endregion

        #region Fields

        private string publicationName;
        private int volumeNumber;
        private int issueNumber;
        private decimal issuePrice;

        #endregion

        #region Constructors

        public Publication(string publicationName, int volumeNumber, int issueNumber, decimal issuePrice, MediaType media)
        {
            this.publicationName = publicationName;
            this.volumeNumber = volumeNumber;
            this.issueNumber = issueNumber;
            this.issuePrice = issuePrice;
            this.Media = media;
        }

        #endregion

        #region Properties

        public static int AvailableIssues
        {
            get
            {
                return MAX_ISSUES_PER_VOLUME;
            }
        }

        public string PublicationName
        {
            get { return publicationName; }
            set
            {
                if (!Validate.ValidGreaterThanLength(value, 1))
                    throw new ArgumentException("Publication Name must be at least two characters");

                publicationName = value;
            }
        }

        public int VolumeNumber
        {
            get { return volumeNumber; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid volume number");

                volumeNumber = value;
            }
        }

        public int IssueNumber
        {
            get { return issueNumber; }
            set
            {
                if (!IsValidIssueNumber(value))
                    throw new ConstraintException("Invalid issue number");

                issueNumber = value;
            }
        }

        public decimal IssuePrice
        {
            get { return issuePrice; }
            set
            {
                if (value <= 0.0m)
                    throw new ArgumentException("Invalid issue price");

                issuePrice = value;
            }
        }

        public MediaType Media { get; set; }

        #endregion

        #region Methods

        public bool IsValidIssueNumber(int issueNumberToCheck)
        {
            if (issueNumberToCheck >= 1 && issueNumberToCheck <= MAX_ISSUES_PER_VOLUME)
                return true;
            return false;
        }

        #endregion

    }

    public enum MediaType
    {
        Digital,
        Print
    }
}
