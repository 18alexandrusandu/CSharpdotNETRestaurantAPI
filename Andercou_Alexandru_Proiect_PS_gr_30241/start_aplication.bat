cd ./Backend
start .\\RestaurantExtended\\RestaurantExtended.sln
start /b start_backend.bat
cd ../Front-end-proiect
start /b start_server_web.bat
start chrome http://localhost:8000/Home.html