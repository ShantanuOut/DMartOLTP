CREATE XML SCHEMA COLLECTION [Stores].[GetEmployeeDetailsXMLSchema]
	AS N'
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema">
	<xsd:element name="EmployeeList">
		<xsd:complexType>
			<xsd:sequence>
				<xsd:element name="Employee" type="emp" maxOccurs="unbounded"/>				
			</xsd:sequence>
		</xsd:complexType>
	</xsd:element>
	<xsd:complexType name="emp">
		<xsd:sequence>
			<xsd:element name="FullName" type="xsd:string"  minOccurs="1"  maxOccurs="1" />
			<xsd:element name="Designation" type="xsd:string"  minOccurs="1"  maxOccurs="1" />
			<xsd:element name="StoreId" type="xsd:integer"  minOccurs="1"  maxOccurs="1" />
			<xsd:element name="BloodGroup" type="xsd:string" minOccurs="0"  maxOccurs="1" />
			<xsd:element name="Address" type="adr" minOccurs="0" maxOccurs="1" />
			<xsd:element name="Reportees" type="rpt"  minOccurs="1"  maxOccurs="1" />
			<xsd:element name="PhoneNumbers" type="phn"  minOccurs="0"  maxOccurs="1" />
		</xsd:sequence>
		<xsd:attribute name="EmpCode" type="xsd:string" use="required" />
	</xsd:complexType>
	<xsd:complexType name="adr">
		<xsd:sequence>
			<xsd:element name="Address1" type="xsd:string" minOccurs="1" maxOccurs="1" />
			<xsd:element name="Address2" type="xsd:string" minOccurs="0" maxOccurs="1" />
			<xsd:element name="Address3" type="xsd:string" minOccurs="0" maxOccurs="1" />
		</xsd:sequence>
	</xsd:complexType>
	<xsd:complexType name="rpt">
		<xsd:sequence>
			<xsd:element name="Reportee" type="xsd:string" minOccurs="0" maxOccurs="unbounded" />
		</xsd:sequence>
		<xsd:attribute name="Count" type="xsd:integer" use="optional" />
	</xsd:complexType>
	<xsd:complexType name="phn">
		<xsd:sequence>		
			<xsd:element name="Phone" minOccurs="0" maxOccurs="unbounded">
				<xsd:complexType>
					<xsd:simpleContent>
						<xsd:extension base="xsd:string">
							<xsd:attribute name="IsPrimary" type="xsd:integer" use="required" />
						</xsd:extension>
					</xsd:simpleContent>
				</xsd:complexType>
			</xsd:element>
		</xsd:sequence>
	</xsd:complexType>
</xsd:schema>'