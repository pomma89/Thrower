﻿# Changelog for PommaLabs.Thrower #

### v2.1.1 (2015-12-27) ###
* RaiseArgumentException now requires the argument name in the same way of other Raise* classes.

### v2.1.0 (2015-12-26) ###
* Calls to all Raise* methods cannot be deleted any more by not defining the USETHROWER compilation symbol.
  The definition of that symbol was the cause of common errors and was not helpful on the performance side.
* Added RaiseObjectDisposedException.
* Added methods for string validation to RaiseArgumentException.
* Initial support for DNX.

### v2.0.3 (2015-10-31) ###
* FastMember.ObjectAccessor now implements IDictionary&lt;string, object&gt;.
* Added HttpException for Web API projects.

### v2.0.2 (2015-10-24) ###
* Embedded FastMember.
* Added a simple reflection-based object validator.

### v2.0.1 (2015-10-10) ###
* All assemblies are now signed.
* Added RaiseNotSupportedException and RaiseIndexOutOfRangeException.
