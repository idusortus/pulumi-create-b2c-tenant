# Automate Creation of a New Azure B2C Tenant  (Windows 10, Linux options exist)

visit https://app.pulumi.com/
- create account
- create key
- install pulumi
- assign pulumi program to Environment PATH:
  - (Example) C:\Users\iduso\.pulumi\bin

- add your pulumi key environment variables:
  - variable name: PULUMI_ACCESS_TOKEN and 
  - variable value: <YOURpulumiAccessKey>  (obtained from:  https://app.pulumi.com/<yourPulumiUserName>/settings/tokens

- run through the pulumi quickstart to verify everything is working (https://www.pulumi.com/get-started/)
- Pulumi re: B2C Creation --> https://www.pulumi.com/docs/reference/pkg/azure-native/azureactivedirectory/b2ctenant/#b2cresourceskuname
