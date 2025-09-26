param webAppName string  // Web App name
param sku string = 'B1'  // App Service Plan SKU
param dotnetVersion string = 'v8.0'  // Runtime version
param location string  // Resource location
param appServicePlanName string

resource appServicePlan 'Microsoft.Web/serverfarms@2020-06-01' = {
  name: appServicePlanName
  location: location
  properties: {
    reserved: false
  }
  sku: {
    name: sku
  }
  kind: 'app'
}

resource appService 'Microsoft.Web/sites@2020-06-01' = {
  name: webAppName  
  location: location
  kind: 'app'
  properties: {
    serverFarmId: appServicePlan.id
    siteConfig: {
      netFrameworkVersion: dotnetVersion
    }
  }
}
