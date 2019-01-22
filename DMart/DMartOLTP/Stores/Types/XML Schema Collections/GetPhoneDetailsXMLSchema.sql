CREATE XML SCHEMA COLLECTION [Stores].[GetPhoneDetailsXMLSchema]
	AS N'
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema">
	<xsd:element name="PhoneEntityIds">
		<xsd:complexType>
			<xsd:sequence>
				<xsd:element name="EntityId" type="xsd:string" minOccurs="1" maxOccurs="unbounded" />
			</xsd:sequence>
		</xsd:complexType>
	</xsd:element>
</xsd:schema>'