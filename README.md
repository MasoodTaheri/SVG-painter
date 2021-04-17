# SVG-painter
Unity Coloring App for Painting SVG file

Please copy SVGImporter.cs  to Library\PackageCache\com.unity.vectorgraphics@2.0.0-preview.14\Editor


Summary of proposed solution (max. half a page). 
My Solution for making a paint book by a single SVG file has 2 part
1-	Import and process content
I searched and test a lot of plugins and codes that exist on the internet. Finally, I decided to use Unity Internal SVG importer that exists in the “vector graphics” package which is more reliable and more stable than other ways that I tested. I just change some parts of the code to separate the SVG parts and generate all parts that exist in the SVG file. And also, I had to change the material for accepting colors better.
So by changing just one file, this process will run automatically and easily. Every time that you import the SVG file, it will imports all parts separately.
2-	Coloring Issues
This part is a simple unity project that read a pixel color of a color pallet and changes the color of the selected object

2- Architecture diagram (including plugins or external tools).
I used the “vector graphics” package that exists in the unity package and changes some lines of it.

High-level design supportive documents:
a.	Detailed description of art import and processing (use text, diagrams and pseudocode as needed for a semi-technical person to understand your logic). 
just import the file. No need to change anythings

Feasibility table for Product expectations in art (Points A-E above), and description of how proposal would fit with each feasible point.  
My way limitations are the limitation of the package that I used for Importing.
This limitation is described at https://docs.unity3d.com/Packages/com.unity.vectorgraphics@2.0/manual/index.html
The SVG importer in this package implements a subset of the SVG 1.1 specification, with some limitations:
•	Text elements are not yet supported (SVG 1.1 section 10)
•	Per-pixel masking is not supported (SVG 1.1 section 14.4)
•	Filter effects are not supported (SVG 1.1 section 15)
•	Any interactivity feature are not supported (SVG 1.1 section 16)
•	Animations are not supported (SVG 1.1 section 19)

Detailed description of how final users would paint colouring areas (use text, diagrams and pseudocode as needed for a semi-technical person to understand your logic).

the process is really easy. 
At first, the User has to select an object as his current object
And after that, select a color form color palette by clicking on it. The selected object’s color will change.

Guidelines for artists so they can create content the system can use as input (max. one page).
There is no need for guidelines for artists.


Table dividing system into components that could be assigned to developers, and a high-level estimation in days.

just need to change a file with the name “SVGImporter.cs” from the roots of the project to the “vector graphics” package folder at “Library\PackageCache\com.unity.vectorgraphics@2.0.0-preview.14

1.	Functional Unity prototype covering the following:
a.	Import of [Playtika-test.svg], including solid colours and gradients (if feasible as per proposal).
b.	User able to paint image in colour areas with solid colours and gradients (if feasible as per proposal). 

