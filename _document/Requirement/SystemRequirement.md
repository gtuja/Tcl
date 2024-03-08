# System requirement.
## Environment
- .NET 8.0
- Visual Studio Code(latest)
## Component
### TaskManager
- TaskManager should control tasks by  identifier and provide it to application.
- TaskManager should provide task control features, e.g., register, deregister, start, stop, pause, resume, etc.
- TaskManager should handle events from tasks and set event handler to update user application, e.g., progress, log.
- Event handler shall provided by user application.
### Task
- Task should be identified by task type, e.g., template, doxygen parser, etc.
- Task should define control method shall be used by TaskManager, e.g., start, stop, pause, resume, etc.
- Task should do something independently with input data from user application.
- Task should report status end progress to user application.
- Task should report output in some way, e.g., file, string, etc.
### User application
- User application(UA) should provide controls, e.g., Button, ProgressBar, etc., to accept user action.
- UA should implement ITclApp interface to update controls, e.g., Button, ProgressBar, etc.
- UA shall check the usage of TCL with [Repository](https://github.com/gtuja/Tcl) or [Wiki](https://github.com/gtuja/Tcl/wiki).