CREATE XML SCHEMA COLLECTION [Stores].[EmployeeXMLSchema]
	AS 
'<?xml version="1.0" encoding="utf-8"?>
<xs:schema id="NewDataSet" xmlns="" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
  <xs:element name="Employee">
    <xs:complexType>
      <xs:sequence>
        <xs:element name="FirstName" type="xs:string" minOccurs="1" maxOccurs="1" msdata:Ordinal="0" />
        <xs:element name="LastName" type="xs:string" minOccurs="1" maxOccurs="1" msdata:Ordinal="1" />
        <xs:element name="ReportingManager" type="xs:integer" minOccurs="0" maxOccurs="1" msdata:Ordinal="2" />
        <xs:element name="Address" minOccurs="0" maxOccurs="1">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="AddressLine1" type="xs:string" minOccurs="1" maxOccurs="1" />
              <xs:element name="AddressLine2" type="xs:string" minOccurs="0" maxOccurs="1" />
              <xs:element name="AddressLine3" type="xs:string" minOccurs="0" maxOccurs="1" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="PhoneNumbers" minOccurs="1" maxOccurs="1">
          <xs:complexType>
            <xs:sequence>			  
              <xs:element name="Phone" minOccurs="0" maxOccurs="3">			  
				<xs:complexType>
					<xs:simpleContent>
						<xs:extension base="xs:string">
							<xs:attribute name="IsPrimary" type="xs:integer" use="required" />
						</xs:extension>
					</xs:simpleContent>
				</xs:complexType>
			   </xs:element>
            </xs:sequence>			
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name="IsManager" type="xs:integer" use="required" />
      <xs:attribute name="Designation" type="xs:string" />
      <xs:attribute name="BloodGroup" type="xs:string" />
	  <xs:attribute name="StoreId" type="xs:integer" use="required"/>
    </xs:complexType>
  </xs:element>
  <xs:element name="NewDataSet" msdata:IsDataSet="true" msdata:UseCurrentLocale="true">
    <xs:complexType>
      <xs:choice minOccurs="0" maxOccurs="unbounded">
        <xs:element ref="Employee" />
      </xs:choice>
    </xs:complexType>
  </xs:element>
</xs:schema>'