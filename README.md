# NullReferenceException in C# Property Getter

This repository demonstrates a common error in C# where a `NullReferenceException` can occur when accessing a property before its backing field is initialized.  The `Bug.cs` file contains the erroneous code, while `BugSolution.cs` provides the corrected version.

## Problem

The original code incorrectly handles the case where `MyProperty` is accessed before `_myField` is assigned a value.  This results in a `NullReferenceException`.