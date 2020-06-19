# TestABCUnity
This is a Unity project containing a test harness for the  [ABCUnity Music Layout Library](https://github.com/matthewcpp/abcunity).
It contains tests and baselines for the various rendering functions of the library.

## Configuration
ABCUnity is checked into the Assets folder as a git submodule.  Be sure to initialize it when cloning this repo.
Baseline Comparisons are ins `mscz` format so you will need to use [MuseScore](https://musescore.org/download) to create or view them.

### Viewing the Tests
The test harness is loacated in the `Test.unity` scene.
Enter playmode and select the test which to run from the dropdown menu.
Compare the output with the corresponding baseline file.

### Adding tests
Create a new abc file in the `Assets/StreamingAssets/Tests` folder that contains the test abc code.
Create a new MuseScore file in the `Baselines` folder that correctly renders the functionality you are testing.