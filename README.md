Visual Studio 2019 Bug

Code Analysis incorrectly detects internal abstract methods when inherited by external projects. As a result, there is no way to compile a project that subclasses a class with an internal abstract method. This is a demo of the bug.