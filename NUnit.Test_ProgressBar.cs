// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnit.Test_ProgressBar //!Test jednostkowy "ProgressBar"
{
    [TestFixture(WindowsFramework.WinForms)]
    [TestFixture(WindowsFramework.Wpf)]
    public class ProgressBarTest
    {
        public ProgressBarTest(WindowsFramework framework)
            : base(framework)
        {
        }

        [OneTimeSetUp]
        public void Setup()
        {
            SelectOtherControls();
        }

        [Test]
        public void MinimumValueTest()
        {
            var bar = MainWindow.Get<ProgressBar>("ProgressBar");
            Assert.That(bar.Minimum, Is.EqualTo(0));
        }

        [Test]
        public void MaximumValueTest()
        {
            var bar = MainWindow.Get<ProgressBar>("ProgressBar");
            Assert.That(bar.Maximum, Is.EqualTo(100));
        }

        [Test]
        public void ValueTest()
        {
            var bar = MainWindow.Get<ProgressBar>("ProgressBar");
            Assert.That(bar.Value, Is.EqualTo(50));
        }
    }
}