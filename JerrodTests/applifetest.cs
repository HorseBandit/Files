// Copyright (c) 2023 Files Community
// Licensed under the MIT License. See the LICENSE.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Files.App.Helpers.ServiceRegistration;
using System;

namespace Files.App.Tests.Helpers.ServiceRegistration
{
	[TestClass]
	public class AppLifecycleHelperTests
	{
		private AppLifecycleHelper _appLifecycleHelper;

		[TestInitialize]
		public void Initialize()
		{
			_appLifecycleHelper = new AppLifecycleHelper();
		}

		[TestCleanup]
		public void Cleanup()
		{
			// Cleanup code if required
		}

		[TestMethod]
		public void ConfigureHost_ServicesConfigured_ReturnsConfiguredHost()
		{
			// Arrange is handled by the Initialize method

			// Act
			IHost host = _appLifecycleHelper.ConfigureHost();

			// Assert
			var userSettingsService = host.Services.GetService(typeof(IUserSettingsService));
			Assert.IsNotNull(userSettingsService, "IUserSettingsService should be configured.");
			Assert.IsInstanceOfType(userSettingsService, typeof(UserSettingsService), "Service should be of type UserSettingsService.");

			// You can continue with other services to ensure they are registered properly.
			// Additional assertions for other services can be added here.
		}
	}
}
