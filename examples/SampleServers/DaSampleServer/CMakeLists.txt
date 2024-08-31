set(CMAKE_USER_MAKE_RULES_OVERRIDE
   ${CMAKE_CURRENT_SOURCE_DIR}/c_flag_overrides.cmake)
set(CMAKE_USER_MAKE_RULES_OVERRIDE_CXX
   ${CMAKE_CURRENT_SOURCE_DIR}/cxx_flag_overrides.cmake)
   
PROJECT (OpcDaServer)
cmake_minimum_required(VERSION 2.6)

# OPTIONS
OPTION(BUILD_SERVER_DA	    	"Build Server with OPC DA enabled" ON)
OPTION(BUILD_SERVER_AE	    	"Build Server with OPC AE enabled" OFF)

#SET(CMAKE_VERBOSE_MAKEFILE ON)

# LOAD UA SDK PACKAGE
SET(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/../../../../cmake ${CMAKE_MODULE_PATH})
FIND_PACKAGE(OPCSERVERSDKCLASSIC REQUIRED)

# INCLUDE PATHS
include_directories(${CMAKE_CURRENT_SOURCE_DIR})
include_directories(../../../../src/server/core)
include_directories(../../../../src/server/system)
include_directories(../../../../src/server/customization)
include_directories(../../../../src/server/plugin)

if (WIN32)
	add_definitions(-D_NT_SERVICE)
    add_definitions(-D_CRT_SECURE_NO_WARNINGS)
	add_definitions(-D_OPC_TRACE)
	add_definitions(-D_OPC_WIN32)
endif (WIN32)

# add core sources
set (core_SRCS
    ../../../../src/server/core/OpcCommon.cpp 
    ../../../../src/server/core/MatchPattern.cpp
    ../../../../src/server/core/CoreMain.cpp
    ../../../../src/server/core/OpcString.cpp
    ../../../../src/server/core/OpcText.cpp
    ../../../../src/server/core/OpcTextReader.cpp
    ../../../../src/server/core/OpcTrace.cpp
    ../../../../src/server/core/OpcUtils.cpp
    ../../../../src/server/core/stdafx.cpp
    ../../../../src/server/core/UtilityFuncs.cpp
    ../../../../src/server/core/WideString.cpp
	../../../../src/server/core/OpcDataAccessServer.rgs
	../../../../src/server/core/OpcEventServer.rgs
)
	
source_group("Source Files\\Generic\\Core" FILES 
	../../../../src/server/core/OpcCommon.cpp 
	../../../../src/server/core/MatchPattern.cpp
	../../../../src/server/core/CoreMain.cpp 
    ../../../../src/server/core/OpcString.cpp
    ../../../../src/server/core/OpcText.cpp
    ../../../../src/server/core/OpcTextReader.cpp
    ../../../../src/server/core/OpcTrace.cpp
    ../../../../src/server/core/OpcUtils.cpp
    ../../../../src/server/core/stdafx.cpp
    ../../../../src/server/core/UtilityFuncs.cpp
    ../../../../src/server/core/WideString.cpp
)

if (BUILD_SERVER_DA)
    add_definitions(-D_OPC_SRV_DA)
	include_directories(../../../../src/server/dataaccess)
	# add dataaccess sources
	set (dataaccess_SRCS
		../../../../src/server/dataaccess/AsyncIo2.cpp 
		../../../../src/server/dataaccess/AsyncIo3.cpp 
		../../../../src/server/dataaccess/DaBrowse.cpp 
		../../../../src/server/dataaccess/DataCallbackThread.cpp 
		../../../../src/server/dataaccess/DaDeviceItem.cpp 
		../../../../src/server/dataaccess/DaEnumItemAttributes.cpp 
		../../../../src/server/dataaccess/DaGenericGroup.cpp 
		../../../../src/server/dataaccess/DaGenericItem.cpp 
		../../../../src/server/dataaccess/DaGenericServer.cpp 
		../../../../src/server/dataaccess/GroupDataObject.cpp 
		../../../../src/server/dataaccess/DaItemProperties.cpp 
		../../../../src/server/dataaccess/OpcEnumVariant.cpp 
		../../../../src/server/dataaccess/DaGroup.cpp 
		../../../../src/server/dataaccess/DaGroup_Custom.cpp 
		../../../../src/server/dataaccess/DaGroup_Dispatch.cpp 
		../../../../src/server/dataaccess/DaItem.cpp 
		../../../../src/server/dataaccess/DaComServer.cpp 
		../../../../src/server/dataaccess/DaComBaseServer.cpp 
		../../../../src/server/dataaccess/DaComBaseServer_Custom.cpp 
		../../../../src/server/dataaccess/DaComBaseServer_Dispatch.cpp 
		../../../../src/server/dataaccess/DaPublicGroup.cpp 
		../../../../src/server/dataaccess/DaPublicGroupManager.cpp 
		../../../../src/server/dataaccess/ReadWriteLock.cpp 
		../../../../src/server/dataaccess/DaBaseServer.cpp 
		../../../../src/server/dataaccess/DaAsynchronousThread.cpp 
		../../../../src/server/dataaccess/VariantCompare.cpp 
		../../../../src/server/dataaccess/VariantConversion.cpp 
		../../../../src/server/dataaccess/VariantPack.cpp 
	)
	
	source_group("Source Files\\Generic\\Da" FILES 
		../../../../src/server/dataaccess/AsyncIo2.cpp 
		../../../../src/server/dataaccess/AsyncIo3.cpp 
		../../../../src/server/dataaccess/DaBrowse.cpp 
		../../../../src/server/dataaccess/DataCallbackThread.cpp 
		../../../../src/server/dataaccess/DaDeviceItem.cpp 
		../../../../src/server/dataaccess/DaEnumItemAttributes.cpp 
		../../../../src/server/dataaccess/DaGenericGroup.cpp 
		../../../../src/server/dataaccess/DaGenericItem.cpp 
		../../../../src/server/dataaccess/DaGenericServer.cpp 
		../../../../src/server/dataaccess/GroupDataObject.cpp 
		../../../../src/server/dataaccess/DaItemProperties.cpp 
		../../../../src/server/dataaccess/OpcEnumVariant.cpp 
		../../../../src/server/dataaccess/DaGroup.cpp 
		../../../../src/server/dataaccess/DaGroup_Custom.cpp 
		../../../../src/server/dataaccess/DaGroup_Dispatch.cpp 
		../../../../src/server/dataaccess/DaItem.cpp 
		../../../../src/server/dataaccess/DaComServer.cpp 
		../../../../src/server/dataaccess/DaComBaseServer.cpp 
		../../../../src/server/dataaccess/DaComBaseServer_Custom.cpp 
		../../../../src/server/dataaccess/DaComBaseServer_Dispatch.cpp 
		../../../../src/server/dataaccess/DaPublicGroup.cpp 
		../../../../src/server/dataaccess/DaPublicGroupManager.cpp 
		../../../../src/server/dataaccess/ReadWriteLock.cpp 
		../../../../src/server/dataaccess/DaBaseServer.cpp 
		../../../../src/server/dataaccess/DaAsynchronousThread.cpp 
		../../../../src/server/dataaccess/VariantCompare.cpp 
		../../../../src/server/dataaccess/VariantConversion.cpp 
		../../../../src/server/dataaccess/VariantPack.cpp 
	)
endif (BUILD_SERVER_DA)

if (BUILD_SERVER_AE)
    add_definitions(-D_OPC_SRV_AE)
	include_directories(../../../../src/server/alarmsevents)

	# add alarmsevents sources
	set (alarmsevents_SRCS
		../../../../src/server/alarmsevents/AeAttributeValueMap.cpp 
		../../../../src/server/alarmsevents/AeEventArea.cpp 
		../../../../src/server/alarmsevents/AeCategory.cpp 
		../../../../src/server/alarmsevents/AeCondition.cpp 
		../../../../src/server/alarmsevents/AeConditionDefinition.cpp 
		../../../../src/server/alarmsevents/AeComBaseServer.cpp 
		../../../../src/server/alarmsevents/AeBaseServer.cpp 
		../../../../src/server/alarmsevents/AeSource.cpp 
		../../../../src/server/alarmsevents/AeComSubscriptionManager.cpp 
		../../../../src/server/alarmsevents/AeEvent.cpp 
		../../../../src/server/alarmsevents/AeAreaBrowser.cpp 
	)
		
	source_group("Source Files\\Generic\\Ae" FILES 
		../../../../src/server/alarmsevents/AeAttributeValueMap.cpp 
		../../../../src/server/alarmsevents/AeEventArea.cpp 
		../../../../src/server/alarmsevents/AeCondition.h 
		../../../../src/server/alarmsevents/AeCondition.cpp 
		../../../../src/server/alarmsevents/AeConditionDefinition.cpp 
		../../../../src/server/alarmsevents/AeComBaseServer.cpp 
		../../../../src/server/alarmsevents/AeBaseServer.cpp 
		../../../../src/server/alarmsevents/AeSource.cpp 
		../../../../src/server/alarmsevents/AeComSubscriptionManager.cpp 
		../../../../src/server/alarmsevents/AeEvent.cpp 
		../../../../src/server/alarmsevents/AeAreaBrowser.cpp 
	)
endif (BUILD_SERVER_AE)

# add system sources
set (system_SRCS
	../../../../src/server/system/OpcSdk_i.c 
)
	
source_group("Source Files\\Generic\\System" FILES 
	../../../../src/server/system/OpcSdk_i.c 
)

# add customization source
set (customization_SRCS
	../../../../src/server/customization/DaConfiguration.cpp
	../../../../src/server/customization/DaServer.cpp
	../../../../src/server/customization/AeServer.cpp
	../../../../src/server/customization/DaAddressSpace.cpp
	../../../../src/server/customization/DeviceItem.cpp
	../../../../src/server/customization/ServerMain.cpp
	../../../../src/server/customization/ServerUpdate.cpp
)
	
source_group("Source Files\\Customization" FILES 
	../../../../src/server/customization/DaConfiguration.cpp
	../../../../src/server/customization/DaServer.cpp
	../../../../src/server/customization/AeServer.cpp
	../../../../src/server/customization/DaAddressSpace.cpp
	../../../../src/server/customization/DeviceItem.cpp
	../../../../src/server/customization/ServerMain.cpp
	../../../../src/server/customization/ServerUpdate.cpp
)

# add generic plugin sources
set (genericplugin_SRCS
	../../../../src/server/plugin/IClassicBaseNodeManager.cpp
)
	
source_group("Source Files\\Generic\\Plugin" FILES 
	../../../../src/server/plugin/IClassicBaseNodeManager.cpp
)

# add plugin sources
set (plugin_SRCS
	OpcDaServer.rc
	ClassicNodeManager.cpp
)
	
source_group("Source Files" FILES 
	ClassicNodeManager.cpp
)

source_group("Resource Files" FILES 
	OpcDaServer.rc
	../../../../src/server/core/OpcDataAccessServer.rgs
	../../../../src/server/core/OpcEventServer.rgs
)
	
# create server executable
add_executable(OpcDaServer WIN32 ${customization_SRCS} ${core_SRCS} ${alarmsevents_SRCS} ${dataaccess_SRCS} ${system_SRCS} ${genericplugin_SRCS} ${plugin_SRCS})
target_link_libraries(OpcDaServer version.lib)

# LINKER PATHS
# link_directories(Debug)
