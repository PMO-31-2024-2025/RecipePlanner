// <copyright file="StatisticTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UnitTests
{
    using BusinessLogic;
    using LiveCharts;
    using UserInterface.MVVM;

    [TestClass]
    public class StatisticTests
    {
        [TestMethod]
        public void ToggleZoomModeTest()
        {
            AccountManager.UpdateLoginedAccount("oleh.chyzhov@gmail.com");
            StatisticsViewModel vm = new StatisticsViewModel();
            Assert.AreEqual(vm.ZoomingMode, ZoomingOptions.None);
            vm.ExecuteToggleZoomModeCommand();
            Assert.AreEqual(vm.ZoomingMode, ZoomingOptions.X);
            vm.ExecuteToggleZoomModeCommand();
            Assert.AreEqual(vm.ZoomingMode, ZoomingOptions.Y);
            vm.ExecuteToggleZoomModeCommand();
            Assert.AreEqual(vm.ZoomingMode, ZoomingOptions.Xy);
        }
    }
}
