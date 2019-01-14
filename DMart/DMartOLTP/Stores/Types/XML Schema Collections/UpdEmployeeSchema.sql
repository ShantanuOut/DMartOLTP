CREATE XML SCHEMA COLLECTION [Stores].[UpdEmployeeSchema]
	AS N'
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema">
	<xsd:element name="EmployeeUpdate">
		<xsd:complexType>
			<xsd:sequence>
				<xsd:element name="FirstName" type="xsd:string" minOccurs="0" maxOccurs="1" />
				<xsd:element name="LastName" type="xsd:string" minOccurs="0" maxOccurs="1" />
				<xsd:element name="Address" type="adr" minOccurs="0" maxOccurs="1" />
				<xsd:element name="StoreId" type="xsd:integer" minOccurs="0" maxOccurs="1" />
				<xsd:element name="BloodGroup" type="xsd:string" minOccurs="0" maxOccurs="1" />
				<xsd:element name="Designation" type="xsd:string" minOccurs="0" maxOccurs="1" />				
			</xsd:sequence>
		</xsd:complexType>
	</xsd:element>
	<xsd:complexType name="adr">
		<xsd:sequence>
			<xsd:element name="AddLine1" type="xsd:string" minOccurs="0" maxOccurs="1" />
			<xsd:element name="AddLine2" type="xsd:string" minOccurs="0" maxOccurs="1" />
			<xsd:element name="AddLine3" type="xsd:string" minOccurs="0" maxOccurs="1" />
		</xsd:sequence>
	</xsd:complexType>
</xsd:schema>'
