Test Automation Framework
Project Name: Test Automation Framework

🖥 Language: C#

🧪 Testing Approach: BDD (Behavior-Driven Development)

🎯 Purpose:

A robust and maintainable test automation framework designed to support Behavior-Driven Development using Cucumber syntax via SpecFlow alternatives, given SpecFlow is no longer actively maintained. This framework enables seamless collaboration between developers, testers, and non-technical stakeholders by using human-readable feature files to define system behavior.

🧱 Core Features:

BDD-style test automation using Gherkin syntax

Page Object Model (POM) for scalable and maintainable UI tests

Cross-browser support with automatic driver management

NUnit for test execution and reporting

📦 NuGet Packages Used:

NUnit – Test framework for structuring and executing tests

Microsoft.Extensions.Configuration.Json - Ability to read Json files

WebDriverManager – Automatically manages browser driver binaries

Selenium.WebDriver – Core library for browser automation

Selenium.Support – Provides additional support for advanced WebDriver capabilities

Extentnet.core - Generates HTML Reporting

Reqnroll - open-source .NET BDD framework Reqnroll is an open-source Cucumber-style BDD test automation framework for .NET. It has been created as a reboot of the SpecFlow project.

Serilog , Serilog.Sinks.File Serilog.Enrichers.Thread- Used for logging

GUIDE - Install Reqnroll within Extenstion Manager Install Nuget packages Create projects - Scalablity by using multiple projects within one solution

what does each file do

-- Folder/File Structure

Solution: TestAutomationCVExample

Project: TestAutomationCVExample.Core

Summary: Used for interfaces , Framework utilties

TestAutomationCVExample.Core

Solution: TestAutomationCVExample

Project: TestAutomationCVExample.Core

Summary: Used for interfaces and framework utilities.

TestAutomationCVExample.Core/

Interfaces/ - Interfaces for abstraction

├── LocalWebDriver/ - Browser driver setup and management

├── Logging/ - Custom logging logic

├── Reports/ - Report generation (e.g., HTML, ExtentReports)

Project: TestAutomationFramework.UI

Summary: Contains Page Object Model classes, test steps, and BDD features.

TestAutomationFramework.UI/

├── Pages/ - Page Object Model classes

├── Steps/ - Step definitions for BDD scenarios

├── Features/ - Gherkin-style .feature files

├── Hooks/ - Setup and teardown logic for tests

Project: TestAutomationFramework.Tests

Summary: Additional features, test data, and shared resources.

TestAutomationFramework.Tests/

├── Features/ - Additional grouped feature files

├── Resources/ - Shared test data and configuration files

Structure diagram

What each file and method does

TEST CASES
Login
