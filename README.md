# ARIAR_PayrollSystem: Comprehensive Desktop Payroll Management

## Overview

The ARIAR_PayrollSystem is a feature-rich desktop application built with C# and Windows Forms, designed to streamline employee payroll and attendance management. It offers comprehensive functionalities, including biometric fingerprint integration, detailed worklog tracking, automated payroll calculation, and various reporting capabilities. The system is designed to be highly configurable, with a modern user interface powered by Guna.UI2.WinForms.

**Important Note:** This repository contains the **client-side (Windows Forms) application only**. It relies on a separate backend API for data storage and business logic. The API endpoint is configurable within `AppApiUri.json`. You will need to have a compatible backend API running for this application to function correctly.

## Features

*   **Secure User Authentication:**
    *   Admin and Attendance-only login modes.
    *   Role-based access control with granular permissions (e.g., employee management, attendance, payroll, reports, system settings).
*   **Employee Management:**
    *   Complete CRUD (Create, Read, Update, Delete) operations for employee profiles.
    *   Capture and manage employee biometric (fingerprint) data.
    *   View detailed personal, contact, and employment information.
    *   Filter and sort employee lists by various criteria (marital status, position, active status, gender).
*   **Biometric Attendance Tracking:**
    *   Integration with DigitalPersona U.are.U fingerprint readers for time-in/time-out.
    *   Real-time display of attendance logs.
    *   Text-to-Speech (TTS) notifications for attendance events (e.g., "TIME IN", "INVALID FINGERPRINT").
*   **Worklog Management:**
    *   View daily attendance logs for all employees.
    *   Track present, absent, and on-leave employee counts.
    *   Manual attendance logging and leave management.
    *   Generate attendance summary reports.
*   **Payroll Calculation & Details:**
    *   Automated calculation of gross and net salaries.
    *   Detailed breakdown of SSS, PhilHealth, Pag-IBIG contributions (employee and employer shares).
    *   Calculation of late, undertime, and other deductions.
    *   View comprehensive payroll calculation details for each employee.
*   **Reporting:**
    *   Generate Monthly Payroll Summary Reports.
    *   Generate Annual Payroll Reports.
    *   Print individual payslips.
    *   Attendance log reports.
*   **System Maintenance:**
    *   Configure core system settings, including:
        *   Attendance type (In/Out or Full Day).
        *   Early out and late attendance cut-off times.
        *   Enable/disable deductions for late and undertime.
        *   Set deduction rates per minute (late) and per hour (undertime).
        *   Configure Text-to-Speech (TTS) voice (male/female).
    *   Manage user accounts (create, update, delete users and their permissions).
    *   Manage job positions (create, update, delete positions).
*   **Data Backup:** Functionality to trigger data backup (details depend on backend implementation).
*   **Intuitive User Interface:** Modern and responsive design built with Guna.UI2.WinForms.

## Technologies Used

*   **Client-side:**
    *   C# (.NET Framework 4.8)
    *   Windows Forms
    *   **Guna.UI2.WinForms:** Modern UI framework.
    *   **DigitalPersona U.are.U SDK (DPUruNet):** For fingerprint reader integration.
    *   **Newtonsoft.Json:** For JSON serialization and deserialization in API communication.
    *   **Microsoft ReportViewer:** For generating dynamic reports.
    *   **System.Speech.Synthesis:** For Text-to-Speech capabilities.
*   **Backend:**
    *   This client-side application communicates with a **separate RESTful API**. The backend API for this system can be found here: [jedangelo/ariar_payroll_api](https://github.com/jedangelo/ariar_payroll_api).

## Setup Instructions

To get the ARIAR_PayrollSystem client application up and running, follow these steps:

### Prerequisites

1.  **Visual Studio:** Visual Studio 2019 or later (recommended).
2.  **.NET Framework 4.8 Developer Pack:** Ensure you have this installed.
3.  **DigitalPersona U.are.U SDK:** You need to install the DigitalPersona U.are.U SDK on your development machine to compile and run the biometric features. This typically includes `DPCtlUruNet.dll` and `DPUruNet.dll`. The `.csproj` references these from a local path: `C:\Program Files\DigitalPersona\U.are.U SDK\Windows\Lib\.NET\DPCtlUruNet.dll`. You might need to adjust this path or install the SDK to this default location.
4.  **Backend API:**
    *   You **must have the backend API running** and accessible from your client machine. Please refer to the [ARIAR_Payroll_API repository](https://github.com/jedangelo/ariar_payroll_api) for its setup instructions.
5.  **Compatible Fingerprint Reader:** A DigitalPersona U.are.U series fingerprint reader is required for biometric attendance features.

### Installation

1.  **Clone the Repository:**
    ```bash
    git clone https://github.com/jedangelo/ariar_payrollsystem.git
    cd jedangelo-ariar_payrollsystem
    ```

2.  **Open in Visual Studio:**
    Open the `PayrollSystem.sln` file located in the root of the cloned repository.

3.  **Restore NuGet Packages:**
    Visual Studio should automatically prompt you to restore missing NuGet packages. If not, right-click on the `PayrollSystem` solution in the Solution Explorer and select "Restore NuGet Packages".

4.  **Configure API Endpoint:**
    *   Navigate to the `PayrollSystem` project folder (e.g., `jedangelo-ariar_payrollsystem/PayrollSystem/`).
    *   Open `AppApiUri.json`.
    *   Update the `"Uri"` value to point to your running backend API's base URL (e.g., `"http://your-api-server:your-port"`).
        ```json
        {
          "Uri": "http://localhost:2410"
        }
        ```
        (The default `http://localhost:2410` is a placeholder, ensure it matches your API's running address.)

5.  **Build the Solution:**
    *   Build the entire solution (`Build > Build Solution` or `Ctrl+Shift+B`).
    *   Ensure there are no compilation errors. If you encounter issues with `DPUruNet`, verify your DigitalPersona SDK installation and the assembly references in the `PayrollSystem.csproj` file.

### Running the Application

1.  **Start the Backend API:** Ensure your backend API is running first.
2.  **Run from Visual Studio:** Press `F5` or click `Debug > Start Debugging`.
3.  **Run Executable:** The compiled executable will be located in the `PayrollSystem/bin/Debug/` (or `PayrollSystem/bin/Release/`) directory. You can run `PayrollSystem.exe` directly.

### Initial Login Credentials

Upon first launch, you will be presented with a login screen.

*   **Attendance-Only Mode:** Click the "Attendance Only" button. This bypasses the full admin login and directly enters a simplified attendance logging interface. The default credentials for this mode are:
    *   **Username:** `attendance`
    *   **Password:** `attendance`
*   **Full System Access (Admin):** Use the following default credentials (these can be changed via the User Management section in System Maintenance). These credentials are managed by the backend API's user authentication system.
    *   **Username:** `admin`
    *   **Password:** `admin`

    *Note: It is highly recommended to change these default administrative credentials immediately after the first successful login.*

## Usage

*   **Login:** Enter your username and password. For attendance-only mode, use the designated button.
*   **Navigation:** Once logged in, use the sidebar menu to navigate between different modules (Employee, Attendance, Work Logs, Payroll, Reports, Maintenance).
*   **Biometrics:** Connect a DigitalPersona fingerprint reader. The system will detect it and enable biometric attendance scanning.
*   **API Configuration (F12):** Press `F12` on the login screen or within the `MainForm` to open the API Switcher modal, allowing you to quickly change the API URI without editing the JSON file.
