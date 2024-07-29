#!/usr/bin/env bash

# set project directory name
PROJECT_DIR ="1-new_project"

# Create the project directory if it doesn't exist
if [ ! -d "$PROJECT_DIR"]; then
    mkdir "$PROJECT_DIR"
    echo "Directory '$PROJECT_DIR' created."
else
    echo "Directory '$PROJECT_DIR' already exists."

fi

# navigate into the project directory
cd "$PROJECT_DIR"

# Initialize a new C# console project
dotnet new console

# Build the C# project
dotnet build
