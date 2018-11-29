FROM ubuntu:latest

RUN apt update && apt install nginx -y

RUN apt install nano -y

COPY web /var/www/html

CMD ["/bin/bash"]

#Exponer puerto
#EXPOSE 80

#nginx auto
#CMD ["nginx", "-g", "daemon off;"]