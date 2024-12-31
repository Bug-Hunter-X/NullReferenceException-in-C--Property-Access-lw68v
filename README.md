# NullReferenceException in C# Property Access

This repository demonstrates a common C# bug: a `NullReferenceException` occurring when accessing a property that may not have been properly initialized.  The `bug.cs` file shows the problematic code, while `bugSolution.cs` provides a corrected version.

## Bug Description

A `NullReferenceException` is thrown when trying to access a member (in this case, a property) of an object that is currently null. This often occurs due to improper object initialization or a failure to handle null values before using them.

## Solution

The solution involves using null checks before accessing the property.  This can be done with the null-conditional operator (`?.`) or using explicit `if` checks to avoid accessing the property when it's null.