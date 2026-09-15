# EventEase Blazor App

EventEase is a small Blazor application for browsing upcoming events, registering attendees, and tracking participation.

## Features

- Event cards with event details and registration actions
- Registration form with validation
- Routing between the home page, registration page, and attendance tracker
- Simple user session state for the currently signed-in attendee
- Attendance tracker to review registrations

## Microsoft Copilot workflow summary

### 1. Event card generation
Copilot helped generate the Event card structure, including fields such as title, date, location, description, capacity, and seats left. It also suggested a clean way to bind the card properties to the UI and trigger navigation to the registration page.

### 2. Routing and navigation
Copilot assisted with creating the route configuration and navigation logic for pages such as the home page and registration page. This included fixing navigation patterns and ensuring each page mapped correctly to the app structure.

### 3. Debugging and optimization
Copilot was used to identify issues related to routing setup, layout structure, and validation. It helped simplify the code and remove unnecessary template elements so the app stayed focused and performant.

### 4. Form validation and session state
Copilot supported the creation of the registration form, including `DataAnnotationsValidator`, validation rules, and state updates for the current user session. It also helped connect the form to the attendance tracker.

### 5. Attendance tracker
Copilot helped design the attendance summary and attendee list so the app could track registrations and show total counts clearly.

## Project setup

```bash
dotnet restore
dotnet build
dotnet run
```

## GitHub repository

The project is hosted in a public GitHub repository for review.
