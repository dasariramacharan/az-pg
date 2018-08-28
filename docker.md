## List Docker CLI commands
docker
docker container --help

## Display Docker version and info
docker --version
docker version
docker info

## Execute Docker image
docker run hello-world

## List Docker images
docker image ls

## List Docker containers (running, all, all in quiet mode)
docker container ls
docker container ls --all
docker container ls -aq


  *   docker  build -t friendlyhello .  # Create image using this directory's   *   docker file
  *   docker  run -p 4000:80 friendlyhello  # Run "friendlyname" mapping port 4000 to 80
  *   docker  run -d -p 4000:80 friendlyhello         # Same thing, but in detached mode
  *   docker  container ls                                # List all running containers
  *   docker  container ls -a             # List all containers, even those not running
  *   docker  container stop <hash>           # Gracefully stop the specified container
  *   docker  container kill <hash>         # Force shutdown of the specified container
  *   docker  container rm <hash>        # Remove specified container from this machine
  *   docker  container rm $(  *   docker  container ls -a -q)         # Remove all containers
  *   docker  image ls -a                             # List all images on this machine
  *   docker  image rm <image id>            # Remove specified image from this machine
  *   docker  image rm $(  *   docker  image ls -a -q)   # Remove all images from this machine
  *   docker  login             # Log in this CLI session using your   *   docker  credentials
  *   docker  tag <image> username/repository:tag  # Tag <image> for upload to registry
  *   docker  push username/repository:tag            # Upload tagged image to registry
  *   docker  run username/repository:tag                   # Run image from a registry



Location where Images are stored => C:\Users\Public\Documents\Hyper-V\Virtual hard disks

On Windows, explicitly stop the container
                      On Windows systems, CTRL+C does not stop the container. So, first type CTRL+C to get the prompt back (or open another shell), then type docker container ls to list the running containers, followed by docker container stop <Container NAME or ID> to stop the container. Otherwise, you get an error response from the daemon when you try to re-run the container in the next step.




                    Items To Try
                    
Play with Docker Classroom online - Getting Started Walk-through 
https://training.play-with-docker.com/#dev


Check below later :

Windows Containers Documentation
https://docs.microsoft.com/en-us/virtualization/windowscontainers/index

