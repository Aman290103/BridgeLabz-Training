AI-Driven Resume Screening System
o Concepts: Generic Classes, Generic Methods, Constraints
o Problem Statement: Develop a resume screening system that can
process resumes for different job roles while ensuring type safety.
o Hints:
 Create an abstract class JobRole (SoftwareEngineer,
DataScientist).
 Implement a generic class Resume&lt;T&gt; where T : JobRole to
process resumes dynamically.
 Use List&lt;T&gt; to handle multiple job roles in the screening
pipeline.