# Module Formats (Syntax) and Module Loaders (Execution)

## Module Formats  

### Overview
The module format is just a syntax that could be used to define a module.
- **AMD** (Asynchronous module definition)
- **CommonJS** (used by Node.js)
- **UMD** (Universal Module Definition)
- **System.register** 
- **ES6 Native Format**

## Module Loaders

### Overview
The module loaders interpret and load a module written in a given module format.
- **RequireJS**
	-  Most popular for browsers
	- Works with AMD format

- **SystemJS**
	- Prefered for server-side
	- Supports AMD, CommonJS, UMD, System.register
	- The one used in Node.js is CommonJS

## AMD and RequireJS
### Fast Syntax
``` js
define([ (1) ], function( (2) ){
   return { (3) } 
})
(1) /array with path of each of the js files to be included(i.e dependencies)/
(2) /dependent modules included/
(3) /the value that this module will export/
```
*Learn more about the syntax [here](http://requirejs.org/docs/whyamd.html#definition)*

### Install & Config RequireJS

0. It's a good idea to create a .json file beforehand
1. Write this commamd in the terminal:
``` js
npm install --save requirejs
```

2. Write this <script> to set the path to your app. (data-main attribute should point to the main file of you application and it's not necessary this file to be named app.js, but it's a good idea to be named so)
``` js
<script data-main="./app.js" src="node_modules/requirejs/require.js">
</script>
```

## CommonJS & SystemJS

### Syntax

``` js
// Importing external dependent modules
let player = require('./player.js'); 
...
...
...
// Exporting modules
exports.sayHello = sayHello; 
// module.exports === exports 
```

### Install & Config SystemJS

0. It's a good idea to create a .json file beforehand;
1. Write this commamd in the terminal:
``` js
npm install --save systemjs
```

2. Load the library SystemJS in the main HTML file:
```js
<script src="node_modules/systemjs/dist/system.js"></script>
```

3. After loading the library, write this script tag to configure the path to the main js file of the application
(it's frequently named app.js)
```js
<script>
  System.config({ meta: { format: 'cjs' } });
  System.import('./app.js');
</script>
```

### One possible problem:
When requiring files with CommonJS, we should know if we will test our application in the browser or in Node.
- **in browser** -> **add .js** extension after the name of the file in the file path;
- **in Node** -> there is **no need** to add .js extension.


## ES6 Native Modules

### Overview

ES6 Native Module have functions similar to the other module formats, but with the difference that it doesn't need an external library to load them.

### Syntax
- **export** - all the exported functionality is accessible from the other files that imports it;

``` js
export function updateScoreboard(newResult) { … }
export let homeTeam = 'Tigers';
```

``` js
// Exporting multiple members
export { addResult, homeTeam as host };
```

``` js
// Default export - it can be imported without a name
export default function addResult(newResult) { … }
```

- **import**
```js
// import all of the given imported module
import * as scoreboard from './scoreboard.js';
scoreboard.updateScore(); // call from module
```

```js
// Import just specific parts from the given module
import {addResult, homeTeam} from './scoreboard.js';
addResult(); // call directly by name
```

```js
// Default Import - just specify the name of the imported module (the name could be the same as when exported or a different one)
import addResult from './scoreboard.js';
addResult(); // call directly by name
```


## Transpilers

The transiplers convert a code from one programming language to another, or from one version of a given programming language to another version.

## Babel

### Overview
Babel is a transpiler, which we can use to convert a ES6 code to a one, written in ES5. Why, you'll ask? Because of the browsers, some older versions don't support the features of the latest JavaScript standart. 

### Installing Babel

Write this code in the terminal:
``` js
npm install --save-dev babel-cli -g
```

### Configuring Babel in WebStorm
- Adding a file watcher
**File** -> **Settings** -> **Tools** -> **File Watchers** -> **Add (Top Right you'll see a green "+")** -> **Babel**

- Settings to the file watcher
	- Program:	(path to) node_modules\.bin\babel.cmd (Often:  **C:\Users\{username}\AppData\Roaming\npm\babel.cmd**)
	- Arguments:	``$FilePathRelativeToProjectRoot$ --source-maps --out-dir build**``
	- Working dir:	 ``$ProjectFileDir$``
	- Output paths:	**build**

**Hint:**
 Open the search menu of the Windows ant then write ```%appdata```. This variable will lead you to the AppData folder. So find npm folder, then babel.cmd.

AMD & RequireJS Configuration
1. Run this command in the terminal:
```js
npm install --save-dev babel-plugin-transform-es2015-modules-amd
```

2. Run this code in the terminal:
```js
echo { "plugins": ["transform-es2015-modules-amd"] } > .babelrc
```

3. You can run filewatchers (**Ctrl + Shift + A**) on the main .js file in the project, but there could be 2 possible unexpected problems.
- The output folder for the transpiled files could be recursively nested... One possible solution is: 
	- **right click** -> **"Mark directory as: "** -> **"Excluded"** -> delete all the nested folders, **except** of the main build folder.

- You should **manually run** the filewatchers for all the .js files. This happens only once, after that all these files will be watched for any change.

### CommonJS & SystemJS Configuration
1. Run this command in the terminal:
```js
npm install --save-dev babel-plugin-transform-es2015-modules-commonjs
```
2. Run this code in the terminal:
```js
echo { "plugins": ["transform-es2015-modules-commonjs"] } > .babelrc
```
3. Here, the file watcher should be run as mentioned above.

## Resources
I wrote this file with the help of:
- [Software University - JavaScript Advanced](https://softuni.bg/courses/javascript-advanced)
- [ A 10 minute primer to JavaScript modules, module formats, module loaders and module bundlers](https://www.jvandemo.com/a-10-minute-primer-to-javascript-modules-module-formats-module-loaders-and-module-bundlers/#)
