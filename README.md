# CiscoCodeAssesment
Coding Test
 Instructions: 
1. Please complete the following questions. 
2. You can use any coding language (preferably Python or TypeScript) of your choosing.
 3. Code must be compilable/runnable code that can easily run to verify the correct functionality. The choice of the tool to compile, test, and run the code is 
up to you.
 4. You may publish and email a link to your results in Github or provide a   with your results by email. .tar.gez file
 1. Imagine we have an interface  that looks like this: GNode
 interface GNode {
    getName(): string
    getChildren(): GNode[]
 }
 Note that  can be thought of as defining a graph. GNode
 In implementing the functions below, you can assume that any graph defined by a  is acyclic (no cycles). GNode
 Assume that when a  has no children,  returns GNode getChildren() a list of size 0.
 Implement a function with the following signature:
 walkGraph(node: GNode): GNode[]
 which should return a list containing every  in the graph starting with the given . Each node should appear in the list exactly once meaning GNode node
 there will be no duplicates.
 2. Implement a function with the following signature:
 paths(node: GNode): GNode[][]
 which should return a list of lists, representing all possible paths through the graph starting at the given  . The returned list can be thought of as a list node
 of paths, where each path is represented as a list of s. GNode
 Example
 Assume the following graph:
 A
 B
  E
  F
 C
  G
  H
  I 
 D
  J
 paths(A) = ( (A B E) (A B F) (A C G) (A C H) (A C I) (A D J) )
3. Write a quick and dirty program
 Write a script or program to produce a count of all the different "words" in a text file. Use any definition of the word that makes logical sense or makes your 
job easy. The output might look like this:
 17 a 
14 the 
9 of
 9 in
 8 com
 7 you
 7 that
 7 energy 
6 to
 ...
 For this input file, the word "a" occurred 17 times, "the" 14 times, etc.
 4. Extra Credit (not required)
 Write an HTTP server with REST API
 You’re creating a tool that helps people organize documents into different groups called “tags”.
 We can represent each document by a 
URI
 . Each document can have multiple tags. Tags are represented as text strings - you can enforce reasonable 
constraints (i.e. limit length, prevent white-spaces, etc.). Tags form a hierarchy, so each tag can have sub-tags. For example "animals" tag might have sub
tags like "mammals" and "birds" which can have sub-tags of their own. In other words the "is a sub-tag of" relation is transitive.
 Implement an HTTP server that will expose the following API endpoint: GET /taggedContent?tag=<tag>
 This returns a JSON array of documents (represented by URIs) associated with the given tag (and its sub-tags).
 The API is read-only so the "database" of documents and tags can be completely static. You can either hard-code it or preferably read it from a file.
