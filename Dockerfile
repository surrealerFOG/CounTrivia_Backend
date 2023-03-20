# Get the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0

# Add Metadata
LABEL maintainer="Andrin Vincenz" 
LABEL description="This is the Dockerfile for the coun-trivia-backend."

# Set the working directory
WORKDIR /app

# Copy everything from the current directory to the working directory
COPY . .

# Expose the port
EXPOSE 6301

# Run the api
CMD ["dotnet", "run", "--project", "src", "--urls", "http://*:6301"]


# Difference between RUN and CMD
# RUN: executes a command when the image is built used to install dependencies
# CMD: executes a command when the container is started used to start the application

# Difference between CMD and ENTRYPOINT
# CMD: executes a command when the container is started and can be overwritten by the user in the run command
# ENTRYPOINT: executes a command when the container is started and cannot be overwritten

