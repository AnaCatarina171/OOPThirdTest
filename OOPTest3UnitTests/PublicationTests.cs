using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTest3;
using System;
using System.Data;

namespace OOPTest3UnitTests
{

    [TestClass]
    public class PublicationTests
    {
        Publication publication;

        [TestInitialize]
        public void InstantiatePublication()
        {
            publication = new Publication(
                ".NEW News",
                2022,
                1,
                3,
                MediaType.Digital);
        }

        [TestMethod]
        public void CheckIsValidIssueNumber()
        {
            publication.IssueNumber = 11;
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void CheckIsInvalidIssueNumber()
        {
            publication.IssueNumber = 13;
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void NegativeIssueNumber()
        {
            publication.IssueNumber = -9;
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintException))]
        public void ZeroIssueNumber()
        {
            publication.IssueNumber = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckIsInvalidName()
        {
            publication.PublicationName = "A";
        }

        [TestMethod]
        public void CheckIsValidName()
        {
            publication.PublicationName = "Ana";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyName()
        {
            publication.PublicationName = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BlankName()
        {
            publication.PublicationName = " ";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullName()
        {
            publication.PublicationName = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidVolumeNumber()
        {
            publication.VolumeNumber = -8;
        }

        [TestMethod]
        public void ValidVolumeNumber()
        {
            publication.VolumeNumber = 9;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidIssuePrice()
        {
            publication.IssuePrice = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidNegativeIssuePrice()
        {
            publication.IssuePrice = -9;
        }

        [TestMethod]
        public void ValidIssuePrice()
        {
            publication.IssuePrice = 100;
        }
    }
}
