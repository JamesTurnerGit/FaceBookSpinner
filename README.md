# FaceBookSpinner
graphically randomize winner of a "like contest" on facebook.
selected a name from a list of 500+

started in pure c#, ported into unity to take advantage of the simple graphics and sound implementation

## Issues 

Default textbox in unity has a low char limit, could not input the full list of names, Moved to TextMeshPro, a plugin which is going to be intgrated into the next version of unity which also looks a lot nicer. Unfortunatly the Textbox from TextMeshPro Misreports it's height by a few pixels. has been reported to them as a bug.  The reason this creates an issue is that i want to make a seamless loop of names over the screen to increase the flair, but with the misreported height it's never where i expect it to be ( the result box should cover up the name)

## Future plans

Make it able to accept a url as an input instead of copy-pasting in a list of names - (app already strips all non-names from text input)
implement the moving background of the spinner wusing some workarounds.
