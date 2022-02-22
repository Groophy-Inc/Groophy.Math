# Groophy.Math

[![NuGet version (Groophy.Math)](https://img.shields.io/nuget/v/Groophy.Math.svg?style=flat-square)](https://www.nuget.org/packages/Groophy.Math/)

[Source Code](https://github.com/Groophy-Inc/Groophy.Math/blob/main/Groophy.Math/Math.cs)

<details>
  <summary>OVERVIEW</summary>
  
  
    It's still under development!


# Usage

[Addaddition](https://groophy-inc.github.io/GMath/addaddition)

[Subtraction](https://groophy-inc.github.io/GMath/subtraction)

[Multiplication](https://groophy-inc.github.io/GMath/multiplication)

[Division](https://groophy-inc.github.io/GMath/division)

[Modulo](https://groophy-inc.github.io/GMath/modulo)

[Period](https://groophy-inc.github.io/GMath/period)

[Exponent|Power|Caret](https://groophy-inc.github.io/GMath/Exponent)

[Sigma](https://groophy-inc.github.io/GMath/sigma)
        
And more...

## Types
```c#
        public bool get_Bool { get; set; }
        public byte get_Byte { get; set; }
        public sbyte get_Sbyte { get; set; }
        public short get_Short { get; set; }
        public ushort get_UShort { get; set; }
        public int get_Int { get; set; }
        public uint get_UInt { get; set; }
        public long get_Long { get; set; }
        public ulong get_ULong { get; set; }
        public float get_Float { get; set; }
        public double get_Double { get; set; }
        public decimal get_Decimal { get; set; }
        public string get_String { get; set; }
```
```cs
GValue g = new GValue("5");
Short Short_of_g = g.get_Short; //5
```

## Example of Sigma

```c#
public static GValue Sigma(GValue n, GValue to, string formula)
```
```c#
GValue g = Groophy.Math.Math.Sigma(new GValue("2"), new GValue("5"), "n*2");
g.PrintAll();
```
It applies the formula "formula" until the number "n" is increased one by one until the number "to".
> 2*2

> 3*2

> 4*2

> = 18

![sig](https://user-images.githubusercontent.com/77299279/154857845-ee625e49-7bd1-48bf-bf55-aada986ec2bb.PNG)
  
</details>

<details>
  <summary>1.0.0</summary>
Template,
 
Methods with single type parameter(GValue)
        
[Addaddition](https://groophy-inc.github.io/GMath/addaddition)

[Subtraction](https://groophy-inc.github.io/GMath/subtraction)

[Multiplication](https://groophy-inc.github.io/GMath/multiplication)

[Division](https://groophy-inc.github.io/GMath/division)

[Modulo](https://groophy-inc.github.io/GMath/modulo)

[Period](https://groophy-inc.github.io/GMath/period)

[Exponent|Power|Caret](https://groophy-inc.github.io/GMath/Exponent)

[Sigma](https://groophy-inc.github.io/GMath/sigma)
        
---
</details>
        
<details>
  <summary>1.0.1</summary>
Methods with two type parameter(GValue, String) and fixes

[Root](https://groophy-inc.github.io/GMath/root)

[per(%)](https://groophy-inc.github.io/GMath/per)

[Absolute](https://groophy-inc.github.io/GMath/abs)

[Factorial](https://groophy-inc.github.io/GMath/factorial)

[Permutation](https://groophy-inc.github.io/GMath/permutation)
        
[Combination](https://groophy-inc.github.io/GMath/combination)
        
---
</details>

~Groophy Lifefor
