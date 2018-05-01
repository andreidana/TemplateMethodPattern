# TemplateMethodPattern

**Definition** 

Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. 

**Applicability**

The Template Method pattern should be used 

- to implement the invariant parts of an algorithm once and leave it up to subclasses to implement the behavior that can vary.  
- when common behavior among subclasses should be factored and localized in a common class to avoid code duplication. 
- to control subclasses extensions. You can define a template method that calls "hook" operations (see Consequences) at specific points, thereby permitting extensions only at those points.  

**Consequences**

- Inverted control structure.
- Fundamental technique for code reuse
- Unexpected updates.


**Related Patterns**

- [Factory Methods](https://github.com/andreidana/FactoryMethodExample)
- [Strategy](https://github.com/andreidana/StrategyExample)