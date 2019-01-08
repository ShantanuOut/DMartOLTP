CREATE XML SCHEMA COLLECTION [Stores].[ChangeReportingManager]
	AS N'
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema">
	<xsd:element name="ToBeTransferred">
		<xsd:complexType>
			<xsd:sequence>
				<xsd:element name="EmployeeId" type="xsd:integer" maxOccurs="unbounded" />
			</xsd:sequence>
			<xsd:attribute name="NewManagerId" type="xsd:integer" />
		</xsd:complexType>
	</xsd:element>
</xsd:schema>'