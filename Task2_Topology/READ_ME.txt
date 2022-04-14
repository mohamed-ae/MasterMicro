
*Project information:
  - .Net Framework 4.7.2
  - Newtonsoft.Json package for Json operations
  - Task2_Topology: the library project
  - TaskTopologyTesting project in Solution: is just a simple console application to test manually.

*API explanation:
 - path  ---> path to StroageJsonFile.txt
 - StorageJsonFile.txt  ---> a file to store Json/Deserialized string. Acts like a database.
 - Componenet   ---> is a parnt class for devices
 - Device1 and Device2  ---> types of components or devices in a topology.
--------------------------===========-------------------=============--------------
 - fillJsonFile()  --->  fill the file with data (topologies).
 - addTopology()  ---> to add new topology, get data from file first into memory, add new toplogy to memory data,
		 then save memory data to the file again.
 - getTopology(id)  ---> get a topology by topology id.
 - queryTopologies()  ---> return all topologies.
 - deleteTopology(id)  ---> delete topology by topology id
 - queryDevices(id)  ---> return the devices included in topology with id.
 - queryDevicesWithNetlistNode()  ---> return all the devices with Netlist node from all topologies.