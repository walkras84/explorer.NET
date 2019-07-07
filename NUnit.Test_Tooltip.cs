// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System;
using System.Windows.Automation;
using NUnit.Framework;

namespace NUnitTest_Tooltip //!Test jednostkowy "Tooltipa"
{
    [TestFixture(WindowsFramework.WinForms)]
    [TestFixture(WindowsFramework.Wpf)]
    public class TooltipTest
    {
        public TooltipTest(WindowsFramework framework)
            : base(framework)
        {
        }
        [Test]
        public void SprawdzTooltip()
        {
            var button = MainWindow.Get<Button>("Przycisk z tooltipem");
            Assert.That(MainWindow.GetToolTipOn(button).Text, Is.EqualTo("Tooltip"));
        }
    }
}