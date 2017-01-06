<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="0bc6b4ea-3f94-43e8-8e58-ca22a29c92bd" namespace="ConsoleApplication" xmlSchemaNamespace="urn:ConsoleApplication" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="SoT" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="SoT">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/0bc6b4ea-3f94-43e8-8e58-ca22a29c92bd/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="Component" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="component" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/0bc6b4ea-3f94-43e8-8e58-ca22a29c92bd/Component" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="Component">
      <attributeProperties>
        <attributeProperty name="Path" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="path" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/0bc6b4ea-3f94-43e8-8e58-ca22a29c92bd/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Name" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/0bc6b4ea-3f94-43e8-8e58-ca22a29c92bd/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>