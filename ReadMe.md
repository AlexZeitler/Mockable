Welcome to Mockable!

everytime you try to test your .NET objects having external dependencies like database, network or file system, you have to do the same thing: mock it.

If your dependency is implementing an interface everything is fine as you can mock it use the mocking framework of your choice.

If your dependency is not implementing an interface, you have two choices:

* use comercial tools like Typemock Isolator
* hide the implementation of the dependency behind an interface and write your own implementation for test and production usage ([Hiding behind an interface explained](http://stackoverflow.com/questions/266776/mock-file-methods-in-net-like-file-copy1-txt-2-txt))

The latter is done repeatedly every day in developers cubicles.

The aim of Mockable is to provide interfaces and implemenations for the default behaviors of the .NET Framework classes to ease mocking.