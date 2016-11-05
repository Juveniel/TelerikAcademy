# Strategy Pattern

In computer programming, the strategy pattern (also known as the policy pattern) is a software 
design pattern that enables an algorithm's behavior to be selected at runtime. The strategy pattern:

- defines a family of algorithms,
- encapsulates each algorithm, and
- makes the algorithms interchangeable within that family.

Strategy lets the algorithm vary independently from clients that use it. Strategy is one of the patterns
included in the influential book Design Patterns by Gamma et al. which popularized the concept of using
patterns to describe software design.

For instance, a class that performs validation on incoming data may use a strategy pattern to select a 
validation algorithm based on the type of data, the source of the data, user choice, or other discriminating 
factors. These factors are not known for each case until run-time, and may require radically different 
validation to be performed. The validation strategies, encapsulated separately from the validating object,
may be used by other validating objects in different areas of the system (or even different systems) without 
code duplication.

## UML Diagram

![strategy](http://www.dofactory.com/images/diagrams/net/strategy.gif)