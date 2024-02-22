# Geometric Algebra Methods for Resection Problem

This repository contains a collection of codes that implement the methods developed and presented in the paper "A novel geometric method based on conformal geometric algebra applied to the resection problem in two and three dimensions" addressing the resection problem in both 2D and 3D spaces. The core implementation is done in Python and C#, applying geometric algebra to offer innovative solutions and benchmarks for computational efficiency.

## Overview

The project focuses on applying geometric algebra for solving the resection problem, crucial in fields such as computer vision, robotics, and geodesy. It introduces three distinct methods for tackling this problem:
- Vector geometric algebra
- Cassini's method with conformal geometric algebra
- Collins' method with conformal geometric algebra

These methods are encapsulated within a Jupyter Notebook (`pothenot_GA.ipynb`), demonstrating their implementation in Python. The notebook includes code to calculate various error metrics for each method on a defined 2D surface, along with functionalities for visualizing these metrics through graphs.

Additionally, the repository integrates the "GeometricAlgebraFulcrumLib" library, developed by Ahmad Hosny Eid, to facilitate geometric algebra operations in C#. Within this library, two specific files:
- `GeometricAlgebraFulcrumLib/GeometricAlgebraFulcrumLib.Lite/Samples/Geometry/SnelliusPothenotData2D.cs`
- `GeometricAlgebraFulcrumLib/GeometricAlgebraFulcrumLib.SymbolicApplications/Samples/Geometry/SnelliusPothenotProblemSample.cs`

are dedicated to showcasing the computational efficiency (benchmarks) of the algorithms when applied to the resection problem.

## Getting Started

To utilize this repository effectively, follow these steps:

### Prerequisites

- Python 3.8
- Jupyter Notebook
- Install dependencies: clifford, numpy, pickle, plotly, skimage
- .NET Core SDK for C# implementations

### Installation

1. Clone the repository to your local machine.
2. Ensure that Python and Jupyter Notebook are installed on your system.
3. For C# implementations, ensure the .NET Core SDK is installed.

### Running the Python Notebook

Navigate to the repository's root directory and launch Jupyter Notebook:

## Authors of the project

- **Jorge Ventura** 
- **Fernando Martinez**
- **Francisco Manzano-Agugliaro**
- **Aleš Návrat**
- **Jaroslav Hrdina** 
- **Ahmad H. Eid**
- **Francisco G. Montoya**




```bash
jupyter notebook
