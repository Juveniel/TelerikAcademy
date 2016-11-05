# Structural Patterns Brief Description

## Decorator

The role of the Decorator pattern is to provide a way of attaching new state and behavior to an object dynamically. 
The object does not know it is being “decorated,” which makes this a useful pattern for evolving systems.
A key implementation point in the Decorator pattern is that decorators both inherit the original class and contain an instantiation of it.

## Facade

The role of the Façade pattern is to provide different high-level views of subsystems whose details are hidden from users. 
In general, the operations that might be desirable from a user’s perspective could be made up of different selections of parts of the subsystems.

iding detail is a key programming concept. What makes the Façade pattern different from, say, the Decorator or
Adapter patterns is that the interface it builds up can be entirely new. It is not coupled to existing 
requirements, nor must it conform to existing interfaces. 

## Flyweight

The Flyweight pattern promotes an efficient way to share common information present in small objects that occur
in a system in large numbers.It thus helps reduce storage requirements when many values are duplicated. The Flyweight 
pattern distinguishes between the intrinsic and extrinsic state of an object. 

 The greatest savings in the Flyweight pattern occur when objects use both kinds of state but: 
- The intrinsic state can be shared on a wide scale, minimizing storage requirements. 
- The extrinsic state can be computed on the fly, trading computation for storage.