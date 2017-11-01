<!--
    Please leave this section at the top of the breaking change documentation.

    New breaking changes should go under the section titled "Upcoming Breaking Changes", and should adhere to the following format:

    # Upcoming Breaking Changes

    ## Release X.0.0 - January 2017

    The following cmdlets were affected this release:

    **Cmdlet 1**
    - Description of what has changed

    ```powershell
    # Old
    # Sample of how the cmdlet was previously called

    # New
    # Sample of how the cmdlet should now be called
    ```

    Note: the above section follows the template found in the link below: 

    https://github.com/Azure/azure-powershell/blob/dev/documentation/breaking-changes/breaking-change-template.md
-->

# Upcoming Breaking Changes

The following cmdlets were affected this release:

**(Get/Set/New)-AzureRmApplicationGatewaySslCertificate**
- Parameter "Password" being replaced in favor of a SecureString

```powershell

# Old
# (Get/Set/New)-AzureRmApplicationGatewaySslCertificate [other required parameters] -Password "plain-text string"

# New
# (Get/Set/New)-AzureRmApplicationGatewaySslCertificate [other required parameters] -Password $SecureStringVariable
```